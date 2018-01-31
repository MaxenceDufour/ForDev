using BusinessClassPortable;
using ForDev.ClassManager.ManagerLogin;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForDev
{
    /// <summary>
    /// Class ManagerTopic
    /// </summary>
    public class ManagerTopic
    {
        private bool _connection;
        private Person _personConnect;

        public event EventHandler<LoadTopicEventArgs> TopicClick;
        public event EventHandler<LoadTopicEventArgs> TopicDelete;
        public event EventHandler TopicEdit;       
        public List<UcTopic> UcTopicList { get; set; }

        /// <summary>
        /// Build topic header
        /// </summary>
        /// <returns>user control topic</returns>
        public UcTopic TopicHeader()
        {
            UcTopic TopicHeader = new UcTopic();
            TopicHeader.RubricPictContent.Image = new Bitmap(Properties.Resources.IconForDev);
            TopicHeader.ContentText.Text = "Titre";
            TopicHeader.ContentText.Font = new Font(TopicHeader.ContentText.Font, FontStyle.Bold);
            TopicHeader.ContentText.Font = new Font(TopicHeader.Font.FontFamily, 20);
            TopicHeader.ContentText.Margin = new Padding(0,0,0,0);
            TopicHeader.Description.Enabled = true;
            TopicHeader.Description.Visible = true;
            TopicHeader.Description.Text = "Description";
            TopicHeader.Description.Font = new Font(TopicHeader.ContentText.Font, FontStyle.Bold);
            TopicHeader.Description.Margin = new Padding(0,0,0,0);
            TopicHeader.AuthorDateCreate.Enabled = true;
            TopicHeader.AuthorDateCreate.Visible = true;
            TopicHeader.AuthorDateCreate.Text = "Auteur";
            TopicHeader.AuthorDateCreate.Font = new Font(TopicHeader.ContentText.Font, FontStyle.Bold);
            TopicHeader.AuthorDateCreate.Margin = new Padding(0,0,0,0);
            return TopicHeader;
        }

        /// <summary>
        /// Task to build the topic list
        /// Calling async
        /// </summary>
        /// <returns>list user control topic</returns>
        public Task<List<UcTopic>> ListUcTopic()
        {
            TaskScheduler scheduler = TaskScheduler.FromCurrentSynchronizationContext();

            List<Topic> listTopic = new List<Topic>(Controller.GetLastTopicTop10());
            return Task<List<UcTopic>>.Run(() => { return AddTopicInList(listTopic, scheduler); });
        }

        /// <summary>
        /// Task to build the topic list by rubric id
        /// Calling async
        /// </summary>
        /// <param name="rubricId">rubric id</param>
        /// <returns>list user control topic</returns>
        public Task<List<UcTopic>> ListUcTopic(int rubricId)
        {
            TaskScheduler scheduler = TaskScheduler.FromCurrentSynchronizationContext();

            List<Topic> listTopic = new List<Topic>(Controller.GetLastTopicTop10ById(rubricId));
            return Task<List<UcTopic>>.Run(() => { return AddTopicInList(listTopic, scheduler); });
        }

        /// <summary>
        /// builds and adds the user control topic to the list
        /// </summary>
        /// <param name="TopicsList">topic list from db</param>
        /// <param name="scheduler">Used to parry the inter thread call</param>
        /// <returns>list user control topic</returns>
        private List<UcTopic> AddTopicInList(List<Topic> TopicsList, TaskScheduler scheduler)
        {
            UcTopicList = new List<UcTopic>();
            foreach (Topic topic in TopicsList)
            {
                UcTopic tile = new UcTopic();
                tile.RubricPictContent.Image = BuildRubricPicture(topic.Rubric.RubricId);
                tile.ContentText.Text = topic.Title;
                tile.Description.Text = topic.Description;
                tile.AuthorDateCreate.Text = $"écrit par {topic.Person.PersonFirstName} {topic.Person.PersonLastName} le {topic.DateAdd.Day}/{topic.DateAdd.Month}/{topic.DateAdd.Year} à {topic.DateAdd.Hour}:{topic.DateAdd.Minute}";
                tile.Id = topic.TopicId;
                tile.RubricId = topic.Rubric.RubricId;
                tile.ButtonClickTiles += new EventHandler(Topic_Click);
                tile.ButtonDeleteTiles += new EventHandler(DeleteTopic_Click);
                tile.ButtonEditTiles += new EventHandler(EditTopic_Click);
                tile.ButtonValidate += new EventHandler(AcceptEdit_Click);

                //tile.MouseHover += Hover;

                if (scheduler != null)
                {
                    Task.Factory.StartNew(() =>
                    {
                        if (_connection && _personConnect.Privilege > 0)
                        {
                            tile.pictureBoxEdit.Visible = true;
                            tile.pictureBoxEdit.Enabled = true;
                            tile.pictureBoxDelete.Visible = true;
                            tile.pictureBoxDelete.Enabled = true;
                        }
                    }, CancellationToken.None, TaskCreationOptions.None, scheduler);                  
                }

                UcTopicList.Add(tile);
            }
             return UcTopicList; 
        }

        /// <summary>
        /// Assign the icon to the topic
        /// </summary>
        /// <param name="rubricId">rubric id</param>
        /// <returns>image</returns>
        private Image BuildRubricPicture(int rubricId)
        {
            switch (rubricId)
            {
                case 1:
                    return new Bitmap(Properties.Resources.development);
                case 2:
                    return new Bitmap(Properties.Resources.link);
                case 3:
                    return new Bitmap(Properties.Resources.question);
                case 4:
                    return new Bitmap(Properties.Resources.relaxation);
                default:
                    return new Bitmap(Properties.Resources.IconForDev);
            }
        }

        /// <summary>
        /// Modify the behavior after connection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnConnected(object sender, PersonConnectedEventArgs e)
        {
            _connection = true;
            _personConnect = e.PersonConnected;      
        }

        /// <summary>
        /// Modifies the behavior after disconnection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnDisconnected(object sender, EventArgs e)
        {
            _connection = false;
            _personConnect = null;
            UcTopicList.Clear();
        }

        /// <summary>
        /// Use the tab creation method to display topics discussions
        /// </summary>
        /// <param name="sender">user control topic</param>
        /// <param name="e"></param>
        public void Topic_Click(object sender, EventArgs e)
        {
            UcTopic UcTopic = (UcTopic) sender;
            if (TopicClick != null)
                TopicClick(this, new LoadTopicEventArgs {UcTopic = UcTopic});
        }

        /// <summary>
        /// Uses the method of deleting a topic in db
        /// </summary>
        /// <param name="sender">user control topic</param>
        /// <param name="e"></param>
        public void DeleteTopic_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Properties.Resources.VALIDDELETE, Properties.Resources.CAPTIONDELETE, MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                return;

            UcTopic tile = (UcTopic)sender;
            Controller.DeleteTopicInDb(tile.Id);
            if (TopicDelete != null)
                TopicDelete(this, new LoadTopicEventArgs {UcTopic = tile});        
        }

        /// <summary>
        /// Prepares the topic for editing
        /// </summary>
        /// <param name="sender">user control topic</param>
        /// <param name="e"></param>
        public void EditTopic_Click(object sender, EventArgs e)
        {
            UcTopic tile = (UcTopic)sender;
            tile.ButtonClickTiles -= new EventHandler(Topic_Click);
            tile.pictureBoxDelete.Enabled = false;
            tile.pictureBoxDelete.Visible = false;
            tile.pictureBoxEdit.Enabled = false;
            tile.pictureBoxEdit.Visible = false;
            tile.ButtonValidate += new EventHandler(AcceptEdit_Click);
            tile.pictureBoxAccept.Enabled = true;
            tile.pictureBoxAccept.Visible = true;
            tile.ButtonCanceled += new EventHandler(RestoreInitialState_Click);
            tile.pictureBoxCancel.Enabled = true;
            tile.pictureBoxCancel.Visible = true;
            tile.ContentText.BackColor = Color.Aquamarine;
            tile.ContentText.ReadOnly = false;
            tile.Description.BackColor = Color.Aquamarine;
            tile.Description.ReadOnly = false;
            tile.ContentText.Focus();
        }

        /// <summary>
        /// Check the edited topic, add it to the db and restore the initial state
        /// </summary>
        /// <param name="sender">user control topic</param>
        /// <param name="e"></param>
        public void AcceptEdit_Click(object sender, EventArgs e)
        {
            UcTopic tile = (UcTopic)sender;

            if (tile.ContentText.Text == Properties.Resources.EMPTY || tile.Description.Text == Properties.Resources.EMPTY)
                MessageBox.Show(Properties.Resources.EMPTYFIELDS, Properties.Resources.CAPTIONEMPTYFIELDS, MessageBoxButtons.OK);
            else
            {
                Topic newTopic = new Topic(Controller.GetTopicById(tile.Id));
                newTopic.DateUp = DateTime.Now;
                newTopic.Description = tile.Description.Text;
                newTopic.Title = tile.ContentText.Text;
                Controller.EditTopicInDb(newTopic);

                RestoreInitialState_Click(sender, e);
            }
        }

        /// <summary>
        /// Restored the initial state of the topic
        /// </summary>
        /// <param name="sender">user control topic</param>
        /// <param name="e"></param>
        private void RestoreInitialState_Click(object sender, EventArgs e)
        {
            UcTopic tile = (UcTopic)sender;
            tile.ButtonClickTiles += new EventHandler(Topic_Click);
            tile.pictureBoxDelete.Enabled = true;
            tile.pictureBoxDelete.Visible = true;
            tile.pictureBoxEdit.Enabled = true;
            tile.pictureBoxEdit.Visible = true;
            tile.ButtonValidate -= new EventHandler(AcceptEdit_Click);
            tile.pictureBoxAccept.Enabled = false;
            tile.pictureBoxAccept.Visible = false;
            tile.ButtonCanceled -= new EventHandler(RestoreInitialState_Click);
            tile.pictureBoxCancel.Enabled = false;
            tile.pictureBoxCancel.Visible = false;
            tile.ContentText.BackColor = Color.White;
            tile.ContentText.ReadOnly = true;
            tile.Description.BackColor = Color.White;
            tile.Description.ReadOnly = true;
        }
    }
}
