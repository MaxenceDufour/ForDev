using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessClass;

namespace ForDev
{
    public class ManagerTopic
    {
        public event EventHandler TopicClick;
        public event EventHandler TopicDelete;
        public event EventHandler TopicEdit;

        public Controller Controller = new Controller();
        public Person PersonConnect;
        public List<UcTopic> UcTopicList { get; set; }

        public ManagerTopic()
        {
            List<Topic> TopicsList = Controller.GetLastTopicTop10();
            AddTopicInList(TopicsList);
        }

        public ManagerTopic(int rubricId)
        {
            List<Topic> TopicsList = Controller.GetLastTopicTop10ById(rubricId);
            AddTopicInList(TopicsList);
        }

        private UcTopic TopicHeader()
        {
            UcTopic TopicHeader = new UcTopic();
            TopicHeader.RubricPictContent.Image = new Bitmap(Properties.Resources.logoForDevjpg);
            TopicHeader.ContentText.Text = "Titre du topic";
            TopicHeader.ContentText.Font = new Font(TopicHeader.ContentText.Font, FontStyle.Bold);
            TopicHeader.ContentText.Font = new Font(TopicHeader.Font.FontFamily, 20);
            TopicHeader.Description.Enabled = true;
            TopicHeader.Description.Visible = true;
            TopicHeader.Description.Text = "Description en quelques mots...";
            TopicHeader.Description.Font = new Font(TopicHeader.ContentText.Font, FontStyle.Bold);
            TopicHeader.AuthorDateCreate.Enabled = true;
            TopicHeader.AuthorDateCreate.Visible = true;
            TopicHeader.AuthorDateCreate.Text = "Auteur du topic";
            TopicHeader.AuthorDateCreate.Font = new Font(TopicHeader.ContentText.Font, FontStyle.Bold);

            return TopicHeader;
        }

        private void AddTopicInList(List<Topic> TopicsList)
        {
            UcTopicList = new List<UcTopic>();
            UcTopicList.Add(TopicHeader());
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

                if (PersonConnect != null && PersonConnect.Privilege > 0)
                {
                    tile.pictureBoxEdit.Visible = true;
                    tile.pictureBoxEdit.Enabled = true;
                    tile.pictureBoxDelete.Visible = true;
                    tile.pictureBoxDelete.Enabled = true;
                }
                UcTopicList.Add(tile);
            }
        }

        /// <summary>
        /// Assign the icon to the topic
        /// </summary>
        /// <param name="rubricId"></param>
        /// <returns></returns>
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
                    return new Bitmap(Properties.Resources.logoForDevjpg);
            }
        }

        /// <summary>
        /// Use the tab creation method to display topics discussions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Topic_Click(object sender, EventArgs e)
        {
            MyEventArgs f = new MyEventArgs();
            f.EventArgsTopic = (UcTopic) sender;
            if (TopicClick != null)
                TopicClick(this, f);
        }

        private void DeleteTopic_Click(object sender, EventArgs e)
        {
            //if (TopicDelete != null)
            //    TopicDelete(this, e);

            UcTopic tile = (UcTopic)sender;
            Controller.DeleteTopicInDb(tile.Id);
            new ManagerTopic(tile.RubricId);
        }

        private void EditTopic_Click(object sender, EventArgs e)
        {
            //if (TopicEdit != null)
            //    TopicEdit(this, e);

            //Header
            //TopicHeader();

            UcTopic tile = (UcTopic)sender;

            tile.ButtonClickTiles -= new EventHandler(Topic_Click);

            tile.pictureBoxDelete.Enabled = false;
            tile.pictureBoxDelete.Visible = false;
            tile.pictureBoxEdit.Enabled = false;
            tile.pictureBoxEdit.Visible = false;

            tile.ButtonValidate += new EventHandler(AcceptEdit_Click);
            tile.pictureBoxAccept.Enabled = true;
            tile.pictureBoxAccept.Visible = true;
            tile.ButtonCanceled += new EventHandler(CancelEdit_Click);
            tile.pictureBoxCancel.Enabled = true;
            tile.pictureBoxCancel.Visible = true;

            tile.ContentText.BackColor = Color.Aquamarine;
            tile.ContentText.ReadOnly = false;

            tile.Description.BackColor = Color.Aquamarine;
            tile.Description.ReadOnly = false;

            new ManagerTopic(tile.RubricId);
        }

        private void AcceptEdit_Click(object sender, EventArgs e)
        {
            UcTopic tile = (UcTopic)sender;

            if (tile.ContentText.Text == "" || tile.Description.Text == "")
            {
                MessageBox.Show("Tout les champs doivent être renseigné", "Erreur de saisie", MessageBoxButtons.OK);
                return;
            }
            else
            {
                Topic newTopic = new Topic(Controller.GetTopicById(tile.Id));
                newTopic.DateUp = DateTime.Now;
                newTopic.Description = tile.Description.Text;
                newTopic.Title = tile.ContentText.Text;

                Controller.EditTopicInDb(newTopic);

                new ManagerTopic(tile.RubricId);
            }
        }

        private void CancelEdit_Click(object sender, EventArgs e)
        {
            UcTopic tile = (UcTopic)sender;
            new ManagerTopic(tile.RubricId);
        }

        //public void SpecialAccess(PersonConnected person)
        //{
        //    foreach (UcTopic tile in TilesList)
        //    {
        //        if (person != null && person.Privilege > 0)
        //        {
        //            tile.pictureBoxEdit.Visible = true;
        //            tile.pictureBoxEdit.Enabled = true;
        //            tile.pictureBoxDelete.Visible = true;
        //            tile.pictureBoxDelete.Enabled = true;
        //        }
        //        else
        //        {
        //            tile.pictureBoxDelete.Enabled = false;
        //            tile.pictureBoxDelete.Visible = false;
        //            tile.pictureBoxEdit.Enabled = false;
        //            tile.pictureBoxEdit.Visible = false;
        //        }
        //    }
        //}
    }
}
