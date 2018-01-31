using BusinessClassPortable;
using ForDev.ClassManager.ManagerLogin;
using ForDev.ClassManager.ManagerRichTextBox;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using UserEditor;
using Message = BusinessClassPortable.Message;

namespace ForDev
{
    /// <summary>
    /// Class ManagerRichTextBox
    /// </summary>
    public class ManagerRichTextBox
    {
        private bool _connection;
        private Person _personConnected;

        public event EventHandler<AddMessageEventArgs> MessageAdd;
        public List<UcRichTextBox> RTBList = new List<UcRichTextBox>();
        public Message Message;
        public int TopicId;
        public SplitContainer SplitContainer;

        /// <summary>
        /// Build user control RichTextBox
        /// </summary>
        /// <param name="topicId">topic id</param>
        /// <returns>object richTextBox</returns>
        public UcRichTextBox BuildRTB(int topicId)
        {
            UcRichTextBox URTB = new UcRichTextBox();
            URTB.Dock = DockStyle.Fill;
            URTB.ButtonClick += new EventHandler(AddMessage_Click);
            URTB.TopicId = topicId;
            if (_connection)
            {
                URTB.RichTextBox.Text = "";
                URTB.Enabled = true;
            }

            RTBList.Add(URTB);
            return URTB;
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
            foreach (UcRichTextBox ucRichTextBox in RTBList)
            {
                ucRichTextBox.Enabled = true;
                ucRichTextBox.RichTextBox.Text = "";
            }
        }

        /// <summary>
        /// Modifies the behavior after disconnection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnDisconnected(object sender, EventArgs e)
        {
            RTBList.Clear();
            _connection = false;
        }

        /// <summary>
        /// Build and send the message in DB
        /// </summary>
        /// <param name="sender">object richTextBox</param>
        /// <param name="e"></param>
        private void AddMessage_Click(object sender, EventArgs e)
        {
            UcRichTextBox ucRichTextBoxReply = (UcRichTextBox)sender;
            if (ucRichTextBoxReply.RichTextBox.Text.Trim() == Properties.Resources.EMPTY)
            {
                MessageBox.Show(Properties.Resources.EMPTYFIELDS, Properties.Resources.CAPTIONEMPTYFIELDS, MessageBoxButtons.OK);
                return;
            }    
            AddMessageDB(ucRichTextBoxReply);
            ucRichTextBoxReply.RichTextBox.Text = Properties.Resources.EMPTY;
            // Reload message after add
            if (MessageAdd != null)
                MessageAdd(this, new AddMessageEventArgs {TopicId = ucRichTextBoxReply.TopicId});
        }

        /// <summary>
        /// Build the message and send to the add method in the db
        /// </summary>
        /// <param name="ucRTBMessage">the message</param>
        private void AddMessageDB(UcRichTextBox ucRTBMessage)
        {
            Message = new Message();
            Message.ReplyContent = ucRTBMessage.RichTextBox.Rtf; //.Text
            Message.Topic.TopicId = ucRTBMessage.TopicId;
            Message.Person = _personConnected;
            Controller.AddNewTopicReply(Message);
        }
    }
}
