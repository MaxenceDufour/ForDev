using BusinessClassPortable;
using ForDev.ClassManager.ManagerLogin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Message = BusinessClassPortable.Message;

namespace ForDev
{
    /// <summary>
    /// Class ManagerMessage
    /// </summary>
    public class ManagerMessage
    {
        private ToolTip _tt = new ToolTip();
        private bool _connection;
        private List<UcMessage> _listMessageTopics;
        private Person _personConnected;

        public event EventHandler<DeleteMessageEventArg> ReloadMessageList;
        public List<UcMessage> AllMessageTopicsList = new List<UcMessage>();
        public SplitContainer SplitContainer;
        public int TopicId;

        /// <summary>
        /// Built user control message
        /// </summary>
        /// <param name="topicReply">object topicReply</param>
        /// <returns>user control message</returns>
        public UcMessage BuildMessage(Message topicReply)
        {
            UcMessage newUcMessage = new UcMessage();
            newUcMessage.Dock = DockStyle.Top;
            newUcMessage.textBoxResponseName.Text = Properties.Resources.PREFORMATTINGTITLE + topicReply.Topic.Title;
            if(topicReply.ReplyContent.Substring(0,1) == "{")
                newUcMessage.richTextBoxMessage.Rtf = topicReply.ReplyContent;
            else
                newUcMessage.richTextBoxMessage.Text = topicReply.ReplyContent;
            newUcMessage.TopicReplyId = topicReply.TopicReplyId;
            newUcMessage.AuthorId = topicReply.AuthorId;
            newUcMessage.Topic = topicReply.Topic;

            newUcMessage.DeleteClick += new EventHandler(DeleteMessage_Click);
            newUcMessage.PlusClick -= new EventHandler(AddPlusOne_Click);

            if (topicReply.Topic.TypeTopic == (int) BusinessClassPortable.Enum.TypeTopic.Classical)
            {
                newUcMessage.textBoxNbPlus.Visible = false;
                newUcMessage.pictureBoxPlus.Visible = false;
                newUcMessage.pictureBoxBest.Visible = false;
                newUcMessage.pictureBoxPlus.Enabled = false;
            }

            if (topicReply.Topic.TypeTopic == (int)BusinessClassPortable.Enum.TypeTopic.Question)
            {
                if (_connection)
                    if (Controller.CheckVoted(newUcMessage.TopicReplyId, _personConnected.PersonId))
                    {
                        newUcMessage.pictureBoxPlus.Enabled = false;
                        newUcMessage.pictureBoxPlus.Image = Properties.Resources.happy;
                        newUcMessage.PlusClick -= new EventHandler(AddPlusOne_Click);
                    }
                    else
                    {
                        newUcMessage.pictureBoxPlus.Enabled = true;
                        newUcMessage.pictureBoxPlus.Image = Properties.Resources.plus;
                        newUcMessage.PlusClick += new EventHandler(AddPlusOne_Click);
                        _tt.SetToolTip(newUcMessage.pictureBoxPlus, Properties.Resources.TOOLTIPVOTE);
                    }

                newUcMessage.textBoxNbPlus.Visible = true;
                newUcMessage.pictureBoxPlus.Visible = true;
                newUcMessage.textBoxNbPlus.Text = topicReply.Vote.ToString();
                newUcMessage.PlusClick += new EventHandler(AddPlusOne_Click);
            }

            if (_connection && _personConnected.Privilege > 0)
            {
                newUcMessage.panelOption.Enabled = true;
                newUcMessage.panelOption.Visible = true;
                _tt.SetToolTip(newUcMessage.pictureBoxDelete, Properties.Resources.TOOLTIPDELETE);
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

            //ucMessage.pictureBoxAvatar.Image =

            //ucMessage.textBoxProject.Text = $"{ucMessage.textBoxProject.Text} ...";

            //ucMessage.textBoxTech.Text = $"{ucMessage.textBoxTech.Text} ...";
            // For Moderator Privileges
            //if (PersonConnected != null && PersonConnected.Privilege > 0)
            //{
            //    newUcMessage.flowLayoutPanelOption.Visible = true;
            //    newUcMessage.flowLayoutPanelOption.Enabled = true;
            //}
            return newUcMessage;
        }

        /// <summary>
        /// Build a list of user control messages
        /// </summary>
        /// <param name="topicId">topic id</param>
        /// <returns>list user control messages</returns>
        public List<UcMessage> BuildMessageList(int topicId)
        {
            _listMessageTopics = new List<UcMessage>();
            List<Message> listTopicReply = new List<Message>(Controller.GetTopicReplyTop10(topicId));
            foreach (Message topicReply in listTopicReply)
            {
                _listMessageTopics.Add(BuildMessage(topicReply));
                AllMessageTopicsList.Add(BuildMessage(topicReply));
            }
            BestReply(_listMessageTopics);
            return _listMessageTopics;
        }

        /// <summary>
        /// Modify the behavior after connection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">object person</param>
        public void OnConnected(object sender, PersonConnectedEventArgs e)
        {
            _connection = true;
            _personConnected = e.PersonConnected;
            if(_personConnected.Privilege > 0)
                foreach (UcMessage ucMessage in AllMessageTopicsList)
                {
                    ucMessage.panelOption.Visible = true;
                    ucMessage.panelOption.Enabled = true;
                    _tt.SetToolTip(ucMessage.pictureBoxDelete, Properties.Resources.TOOLTIPDELETE);
                }

            foreach (UcMessage messageTopic in AllMessageTopicsList)
            {
                if (Controller.CheckVoted(messageTopic.TopicReplyId, _personConnected.PersonId))
                {
                    messageTopic.pictureBoxPlus.Enabled = false;
                    messageTopic.pictureBoxPlus.Image = Properties.Resources.happy;
                }
                else
                {
                    messageTopic.pictureBoxPlus.Enabled = true;
                    messageTopic.pictureBoxPlus.Image = Properties.Resources.plus;
                    _tt.SetToolTip(messageTopic.pictureBoxPlus, Properties.Resources.TOOLTIPVOTE);
                }
                messageTopic.textBoxNbPlus.Visible = true;
            }
        }

        /// <summary>
        /// Modifies the behavior after disconnection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnDisconnected(object sender, EventArgs e)
        {
            _connection = false;
            AllMessageTopicsList.Clear();
        }

        /// <summary>
        /// Manages the vote on a question
        /// </summary>
        /// <param name="sender">user control message</param>
        /// <param name="e"></param>
        public void AddPlusOne_Click(object sender, EventArgs e)
        {
            UcMessage ucMessage = (UcMessage) sender;

            if (!Controller.CheckVoted(ucMessage.TopicReplyId, _personConnected.PersonId))
            {
                int plusOne = Convert.ToInt32(ucMessage.textBoxNbPlus.Text) + 1;
                ucMessage.textBoxNbPlus.Text = plusOne.ToString();

                Controller.UpdateVoteTopicReply(ucMessage.TopicReplyId, _personConnected.PersonId);

                ucMessage.pictureBoxPlus.Image = Properties.Resources.happy;

                if (ReloadMessageList != null)
                    ReloadMessageList(this, new DeleteMessageEventArg { UcMessage = ucMessage, TopicId = ucMessage.Topic.TopicId });
            }
        }

        /// <summary>
        /// Deletes a message
        /// </summary>
        /// <param name="sender">user control message</param>
        /// <param name="e"></param>
        public void DeleteMessage_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show(Properties.Resources.VALIDDELETE,Properties.Resources.CAPTIONDELETE, MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                return;

            UcMessage ucMessage = (UcMessage)sender;
            Controller.DeleteTopicReplyById(_personConnected.PersonId, ucMessage.TopicReplyId);
            if (ReloadMessageList != null)
                ReloadMessageList(this, new DeleteMessageEventArg {UcMessage = ucMessage, TopicId = ucMessage.Topic.TopicId});
        }

        /// <summary>
        /// Identify the answer with the most votes
        /// </summary>
        /// <param name="list">list user control message</param>
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
                group.msg.pictureBoxBest.Visible = true;
        }
    }
}
