using ForDev.ClassManager.ManagerLogin;
using ForDev.ClassManager.ManagerRichTextBox;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;
using BusinessClassPortable;

namespace ForDev
{
    public partial class Form1 : Form
    {
        public ManagerRubric ObjManagerRubric; 
        public ManagerTopic ObjManagerTopic = new ManagerTopic();
        public ManagerLogin ObjManagerLogin = new ManagerLogin();
        public ManagerLogged ObjManagerLogged = new ManagerLogged();
        public ManagerFormProfil ObjManagerFormProfil = new ManagerFormProfil();
        public ManagerRichTextBox ObjManagerRichTextBox = new ManagerRichTextBox();
        public ManagerMessage ObjManagerMessage = new ManagerMessage();
        public ManagerAddTopic ObjManagerAddTopic = new ManagerAddTopic();

        private List<SplitContainer> splitContainersList = new List<SplitContainer>();
        private List<TabPage> tabPagesList = new List<TabPage>();

        //For Tab
        public int tabIndex = 0;
        private Rectangle myTabRect;
        private Point imageLocation = new Point(15, 5);
        private Point imgHitArea = new Point(13, 2);

        public Form1()
        {
            InitializeComponent();

            // Initialize connection
            string connexionString = ConfigurationManager.ConnectionStrings["user19"].ToString();
            Controller.DAOInitialize(connexionString);

            // Login
            ObjManagerLogin.UcLogin.ButtonClick += ObjManagerLogin.Login_Click;

            // Build rubric and last topic
            ObjManagerRubric = new ManagerRubric();
            ObjManagerTopic.TopicDelete += ReloadTopic;

            BuildRubric();
            BuildTopic();

            // For personalize TabControl
            tabControlApp.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabControlApp.DrawItem += new DrawItemEventHandler(OnDrawItem);

            // Build login control
            tableLayoutPanel6.Controls.Add(ObjManagerLogin.UcLogin, 0, 0);
            ObjManagerLogin.UcLogin.Dock = DockStyle.Fill;         

            ObjManagerLogin.EventConnection += OnConnected;

            // Inisialize UcLogged
            ObjManagerLogged.ProfilClick += new EventHandler(Profil_Click);
            ObjManagerLogged.LogoutClick += new EventHandler(LogOut_Click);
            ObjManagerLogged.TopicAdd += new EventHandler(TopicAdd_Click);

            // Inisialize RichTextBox
            ObjManagerRichTextBox.MessageAdd += ReloadMessage;

            ObjManagerMessage.ReloadMessageList += Reload;

            ObjManagerTopic.TopicClick += Topic_Click;
            ObjManagerRubric.RubrickClick += Rubric_Click;
           
            ObjManagerAddTopic.ButtonAddTopic += new EventHandler(TopicView_Click);

            tt.SetToolTip(ObjManagerLogin.UcLogin.LoginTextBox, "Entrer votre prénom");
            tt.SetToolTip(ObjManagerLogin.UcLogin.PassTextBox, "Entrer votre mot de passe");
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            ObjManagerLogin.UcLogin.LoginTextBox.Focus();
        }

        private void OnConnected(object sender, PersonConnectedEventArgs e)
        {
            labelMessageLog.Visible = false;
            ObjManagerAddTopic.OnConnected(sender, e);
            ObjManagerLogged.OnConnected(sender, e);

            UcLogged ucLogged = ObjManagerLogged.UcLogged;
            tableLayoutPanel6.Controls.Add(ucLogged, 0,0);
            ucLogged.buttonProfil.Focus();

            ObjManagerFormProfil.OnConnected(sender, e);
            ObjManagerRichTextBox.OnConnected(sender, e);
            ObjManagerMessage.OnConnected(sender, e);
            ObjManagerTopic.OnConnected(sender, e);

            panelTopic.Controls.Clear();
            BuildTopic();
        }

        private void BuildRubric()
        {
            ObjManagerRubric.UCRubricsList.Reverse();
            foreach (UcRubric ucRubric in ObjManagerRubric.UCRubricsList)
            {
                panelRubric.Controls.Add(ucRubric);
                ucRubric.Dock = DockStyle.Top;
                tt.SetToolTip(ucRubric.IconRubric, $"Clicker pour afficher les topics de la rubrique \"{ucRubric.LabelRubric.Text}\"");
                tt.SetToolTip(ucRubric.labelRubric, $"Clicker pour afficher les topics de la rubrique \"{ucRubric.LabelRubric.Text}\"");
            }
        }
        private async void BuildTopic()
        {
            List<UcTopic> listTopic = await ObjManagerTopic.ListUcTopic();
            listTopic.Reverse();
            listTopic.Add(ObjManagerTopic.TopicHeader());
            foreach (UcTopic ucTopic in listTopic)
            {
                panelTopic.Controls.Add(ucTopic);
                ucTopic.Dock = DockStyle.Top;
                tt.SetToolTip(ucTopic.ContentText, "Clicker pour afficher les messages du topic");
                tt.SetToolTip(ucTopic.Description, "Clicker pour afficher les messages du topic");
                tt.SetToolTip(ucTopic.RubricPictContent, "Clicker pour afficher les messages du topic");
            }              
        }

        private async void Rubric_Click(object sender, LoadRubricEventArgs e)
        {
            ObjManagerRubric.RubrickClick -= Rubric_Click;
            // Add new title
            labelTitle.Text = e.UcRubric.LabelRubric.Text;

            List<UcTopic> listTopic = await ObjManagerTopic.ListUcTopic(e.UcRubric.RubricId);
            listTopic.Reverse();
            listTopic.Add(ObjManagerTopic.TopicHeader());
            panelTopic.Controls.Clear();
            foreach (UcTopic UCTopic in listTopic)
                panelTopic.Controls.Add(UCTopic);
                
            ObjManagerRubric.RubrickClick += Rubric_Click;
        }

        /// <summary>
        /// Use the tab creation method to display topics discussions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Topic_Click(object sender, LoadTopicEventArgs e)
        {
            ObjManagerTopic.TopicClick -= Topic_Click;
            MakeTabTopicResponse(e.UcTopic); 
            ObjManagerTopic.TopicClick += Topic_Click;
        }

        private async void ReloadTopic(object sender, LoadTopicEventArgs e)
        {
            panelTopic.Controls.Clear();
            List<UcTopic> listUcTopics = await ObjManagerTopic.ListUcTopic(e.UcTopic.RubricId);
            listUcTopics.Reverse();
            listUcTopics.Add(ObjManagerTopic.TopicHeader());
            foreach (UcTopic UCTopic in listUcTopics)
                panelTopic.Controls.Add(UCTopic);
        }

        /// <summary>
        /// Build a new tab with the topics of a topic
        /// </summary>
        /// <param name="sender">Represents the activated tile</param>
        private void MakeTabTopicResponse(object sender)
        {
            UcTopic tiles = (UcTopic)sender;

            SplitContainer splitContainer = CreateSplitContainer(tiles);
            splitContainersList.Add(splitContainer);

            splitContainer.Panel2.Controls.Add(ObjManagerRichTextBox.BuildRTB(tiles.Id));

            foreach (UcMessage messageTopic in ObjManagerMessage.BuildMessageList(tiles.Id))
                splitContainer.Panel1.Controls.Add(messageTopic);

            BuildTabPage(splitContainer, tiles.ContentText.Text);
        }

        private SplitContainer CreateSplitContainer(UcTopic tile)
        {
            SplitContainer splitContainer = new SplitContainer();
            splitContainer.Orientation = Orientation.Horizontal;
            splitContainer.Dock = DockStyle.Fill;
            splitContainer.SplitterDistance = 300;
            splitContainer.Tag = tile.Id;

            splitContainer.Panel1.AutoScroll = true;

            return splitContainer;
        }

        private void ReloadMessage(object sender, AddMessageEventArgs e)
        {
            foreach (SplitContainer splitContainer in splitContainersList)
                if (Convert.ToInt32(splitContainer.Tag) == e.TopicId)
                {
                    splitContainer.Panel1.Controls.Clear();
                    foreach (UcMessage messageTopic in ObjManagerMessage.BuildMessageList(e.TopicId))
                        splitContainer.Panel1.Controls.Add(messageTopic);
                }
        }

        private void Reload(object sender, DeleteMessageEventArg e)
        {
            foreach (SplitContainer splitContainer in splitContainersList)
                if (Convert.ToInt32(splitContainer.Tag) == e.TopicId)
                {
                    splitContainer.Panel1.Controls.Clear();
                    foreach (UcMessage messageTopic in ObjManagerMessage.BuildMessageList(e.TopicId))
                        splitContainer.Panel1.Controls.Add(messageTopic);
                }
        }

        /// <summary>
        /// Build and activate the tab
        /// </summary>
        /// <param name="control">Represents the layout</param>
        /// <param name="nameText">Represents the name of the tile</param>
        private void BuildTabPage(Control control, string tileTitle)
        {
            tabIndex = tabIndex + 1;

            TabPage tabPage = new TabPage();
            tabPage.Controls.Add(control);
            tabPage.Location = new Point(4, 22);
            tabPage.Name = tileTitle;
            tabPage.Padding = new Padding(3);
            tabPage.Size = new Size(1333, 596);
            tabPage.TabIndex = tabIndex;
            tabPage.Text = tileTitle;
            tabPage.UseVisualStyleBackColor = true;

            tabControlApp.Controls.Add(tabPage);
            tabControlApp.MouseClick += TabControlClose_MouseClick;
            tabControlApp.SelectedTab = tabPage;

            tabPagesList.Add(tabPage);
        }

        /// <summary>
        /// Closes the tab
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TabControlClose_MouseClick(object sender, MouseEventArgs e)
        {
            TabControl tc = (TabControl)sender;
            //The first tabPage is not closable
            if (tc.SelectedIndex != 0)
            {
                Point p = e.Location;
                int _tabWidth = 0;
                _tabWidth = this.tabControlApp.GetTabRect(tc.SelectedIndex).Width - (imgHitArea.X);
                Rectangle r = this.tabControlApp.GetTabRect(tc.SelectedIndex);
                r.Offset(_tabWidth, imgHitArea.Y);
                r.Width = 16;
                r.Height = 16;

                if (r.Contains(p))
                {
                    TabPage TabP = (TabPage)tc.TabPages[tc.SelectedIndex];
                    CloseTab(tc, TabP);
                }
            }
        }

        private void CloseTab(TabControl tc, TabPage TabP)
        {
            tc.TabPages.Remove(TabP);
            tabPagesList.Remove(tc.SelectedTab);
            tabIndex = tabIndex - 1;
            TabP.Dispose();
        }

        /// <summary>
        /// Redefined tabs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnDrawItem(object sender, DrawItemEventArgs e)
        {
            //Close Image to draw
            TabControl tc = (TabControl) sender;
            Image img = new Bitmap(Properties.Resources.close);

            Rectangle r = e.Bounds;
            r = this.tabControlApp.GetTabRect(e.Index);
            r.Offset(2, 2);

            Brush TitleBrush = new SolidBrush(Color.Black);
            Font f = this.Font;

            string title = this.tabControlApp.TabPages[e.Index].Text;

            e.Graphics.DrawString(title, f, TitleBrush, new PointF(r.X, r.Y));

            //The first tabPage is not closable, he don't need a close icon
            if (e.Index != 0)
            {
                e.Graphics.DrawImage(img,
                    new Point(r.X + (this.tabControlApp.GetTabRect(e.Index).Width - imageLocation.X - 2),
                        imageLocation.Y));
            }
        }

        // <summary>
        // close the user's session
        // </summary>
        // <param name = "sender" ></ param >
        // < param name="e"></param>
        private void LogOut_Click(object sender, EventArgs e)
        {
            DialogResult Quit = MessageBox.Show(
                "Vous êtes sur le point de vous déconnecter, tout votre travail sera perdu. Etes vous sur de vouloir quité?",
                "Avertissement déconnection", MessageBoxButtons.OKCancel);
            if (Quit == DialogResult.Cancel)
                return;

            ObjManagerLogin.OnDisconnected(sender, e);
            ObjManagerTopic.OnDisconnected(sender, e);
            ObjManagerRichTextBox.OnDisconnected(sender, e);
            ObjManagerLogin.OnDisconnected(sender, e);
            ObjManagerAddTopic.OnDisconnected(sender, e);
            ObjManagerLogged.OnDisconnected(sender, e);
            ObjManagerMessage.OnDisconnected(sender, e);

            // Close and clear all tabPage
            foreach (TabPage tabpage in tabPagesList)
                CloseTab(tabControlApp, tabpage);
            tabPagesList.Clear();
            tabIndex = 0;
            
            // Clear list splitContainer
            splitContainersList.Clear();

            // Clear and relaod topic
            panelTopic.Controls.Clear();
            BuildTopic();

            // Replace title and message
            labelTitle.Text = "Bienvenue sur ForDev";
            labelMessageLog.Visible = true;           
        }

        private void Profil_Click(object sender, EventArgs e)
        {
            labelTitle.Text = "Profil";
            panelTopic.Controls.Clear();
            panelTopic.Controls.Add(ObjManagerFormProfil.BuildProfil());
        }

        private void TopicAdd_Click(object sender, EventArgs e)
        {
            labelTitle.Text = "Ajouter un topic";
            panelTopic.Controls.Clear();       
            panelTopic.Controls.Add(ObjManagerAddTopic.UcAddTopic);
        }

        private async void TopicView_Click(object sender, EventArgs e)
        {
            ManagerAddTopic MAddTopic = (ManagerAddTopic) sender;
            // Add new title
            labelTitle.Text = MAddTopic.UcAddTopic.comboBoxRubric.Text;
            panelTopic.Controls.Clear();
            List<UcTopic> listUctopic = await ObjManagerTopic.ListUcTopic(MAddTopic.Rubric.RubricId);
            listUctopic.Reverse();
            foreach (UcTopic UCTopic in listUctopic)
                panelTopic.Controls.Add(UCTopic);
            panelTopic.Controls.Add(ObjManagerTopic.TopicHeader());
        }

        
    }
}
