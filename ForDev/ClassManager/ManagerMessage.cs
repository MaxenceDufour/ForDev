using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessClass;
using Message = BusinessClass.Message;

namespace ForDev
{
    public class ManagerMessage
    {
        public event EventHandler ReloadMessageList;
        private bool connection;
        public Controller Controller { get; set; } = new Controller();
        
        public Person PersonConnected { get; set; }
        public SplitContainer SplitContainer;
        public int TopicId;
        public ManagerMessage()
        {
           
        }

        public UcMessage BuildMessage(Message topicReply)
        {
            UcMessage newUcMessage = new UcMessage();
            newUcMessage.Dock = DockStyle.Top;
            newUcMessage.textBoxResponseName.Text = $"Re... {topicReply.Topic.Title}";
            newUcMessage.richTextBoxMessage.Text = topicReply.ReplyContent;
            newUcMessage.TopicReplyId = topicReply.TopicReplyId;
            //newUcMessage.SplitContainer = splitContainer;
            newUcMessage.AuthorId = topicReply.AuthorId;
            newUcMessage.Topic = topicReply.Topic;

            newUcMessage.DeleteClick += new EventHandler(DeleteMessage_Click);
            newUcMessage.PlusClick -= new EventHandler(AddPlusOne_Click);

            if (topicReply.Topic.TypeTopic == (int) ForumClass.Enum.TypeTopic.Classical)
            {
                newUcMessage.textBoxNbPlus.Visible = false;
                newUcMessage.pictureBoxPlus.Visible = false;
                newUcMessage.pictureBoxBest.Visible = false;
                newUcMessage.pictureBoxPlus.Enabled = false;
            }

            if (topicReply.Topic.TypeTopic == (int) ForumClass.Enum.TypeTopic.Question)
            {
                if (connection)
                    if (Controller.CheckVoted(newUcMessage.TopicReplyId, PersonConnected.PersonId))
                    {
                        newUcMessage.pictureBoxPlus.Enabled = false;
                        newUcMessage.pictureBoxPlus.Visible = true;
                        newUcMessage.pictureBoxPlus.Image = Properties.Resources.happy;
                        newUcMessage.PlusClick -= new EventHandler(AddPlusOne_Click);
                    }
                    else
                    {
                        newUcMessage.pictureBoxPlus.Enabled = true;
                        newUcMessage.pictureBoxPlus.Visible = true;
                        newUcMessage.pictureBoxPlus.Image = Properties.Resources.plus;
                        newUcMessage.PlusClick += new EventHandler(AddPlusOne_Click);
                    }

                newUcMessage.textBoxNbPlus.Visible = true;
                newUcMessage.pictureBoxPlus.Visible = true;
                newUcMessage.textBoxNbPlus.Text = topicReply.Vote.ToString();

                newUcMessage.PlusClick += new EventHandler(AddPlusOne_Click);
            }

            if (PersonConnected != null && PersonConnected.Privilege > 0)
            {
                newUcMessage.flowLayoutPanelOption.Enabled = true;
                newUcMessage.flowLayoutPanelOption.Visible = true;
                newUcMessage.DeleteClick += new EventHandler(DeleteMessage_Click);
            }

            string dateAdd =
                $"{newUcMessage.textBoxDateCreate.Text} {topicReply.DateAdd.Day}/{topicReply.DateAdd.Month}/{topicReply.DateAdd.Year} à {topicReply.DateAdd.Hour}h{topicReply.DateAdd.Minute}min";
            if (topicReply.DateAdd == topicReply.DateUp)
                newUcMessage.textBoxDateCreate.Text = dateAdd;
            else
                newUcMessage.textBoxDateCreate.Text =
                    $"Mis à jour le {topicReply.DateUp.Day}/{topicReply.DateUp.Month}/{topicReply.DateUp.Year} à {topicReply.DateUp.Hour}h{topicReply.DateUp.Minute}min, {dateAdd}";

            newUcMessage.textBoxName.Text =
                $"{topicReply.AuthorFirstName} {topicReply.AuthorLastName}";
            //TODO avatar/photo de la person
            //ucMessage.pictureBoxAvatar.Image =
            //TODO projet en cour de la personne (V2)
            //ucMessage.textBoxProject.Text = $"{ucMessage.textBoxProject.Text} ...";
            //TODO techno en cour d'utilisation (V2)
            //ucMessage.textBoxTech.Text = $"{ucMessage.textBoxTech.Text} ...";
            // For Moderator Privileges
            //if (PersonConnected != null && PersonConnected.Privilege > 0)
            //{
            //    newUcMessage.flowLayoutPanelOption.Visible = true;
            //    newUcMessage.flowLayoutPanelOption.Enabled = true;
            //}
            return newUcMessage;
        }

        public List<UcMessage> BuildMessageList(int topicId)
        {
            List<UcMessage> listMessageTopics = new List<UcMessage>();
            List<Message> listTopicReply = new List<Message>(Controller.GetTopicReplyTop10(topicId));
            foreach (Message topicReply in listTopicReply)
            {
                listMessageTopics.Add(BuildMessage(topicReply));
            }
            BestReply(listMessageTopics);
            return listMessageTopics;
        }

        public void AddPlusOne_Click(object sender, EventArgs e)
        {
            UcMessage ucMessage = (UcMessage) sender;

            if (!Controller.CheckVoted(ucMessage.TopicReplyId, PersonConnected.PersonId))
            {
                int plusOne = Convert.ToInt32(ucMessage.textBoxNbPlus.Text) + 1;
                ucMessage.textBoxNbPlus.Text = plusOne.ToString();

                Controller.UpdateVoteTopicReply(ucMessage.TopicReplyId, PersonConnected.PersonId);

                ucMessage.pictureBoxPlus.Image = Properties.Resources.happy;
            }
        }

        public void DeleteMessage_Click(object sender, EventArgs e)
        {
            UcMessage ucMessage = (UcMessage) sender;
            Controller.DeleteTopicReplyById(PersonConnected.PersonId, ucMessage.TopicReplyId);
            if (ReloadMessageList != null)
                ReloadMessageList(this, e);
        }

        private void BestReply(List<UcMessage> list)
        {
            var groups = list
                .GroupBy(j => j.Topic.TopicId)
                .Select(j => new
                {
                    j.Key,
                    msg = j.OrderByDescending(p => int.Parse(p.textBoxNbPlus.Text)).FirstOrDefault()
                })
                .Where(j => int.Parse(j.msg.textBoxNbPlus.Text) > 0);

            foreach (var group in groups)
            {
                group.msg.pictureBoxBest.Visible = true;
            }
        }
    }
}
