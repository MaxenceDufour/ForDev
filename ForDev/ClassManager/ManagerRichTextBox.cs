using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessClass;
using UserEditor;
using Message = BusinessClass.Message;

namespace ForDev
{
    public class ManagerRichTextBox
    {
        public event EventHandler MessageAdd;
        public event EventHandler Connected;
        public List<UcRichTextBox> RTBList = new List<UcRichTextBox>();
        private bool connection;
        public Controller Controller { get; set; } = new Controller();
        public Message Message;
        public int TopicId;
        public Person PersonConnected { get; set; }
        public SplitContainer SplitContainer;
        public ManagerRichTextBox()
        {

        }

        public UcRichTextBox CreateRTB(int topicId)
        {
            UcRichTextBox URTB = new UcRichTextBox();
            URTB.Dock = DockStyle.Fill;
            URTB.ButtonClick += new EventHandler(AddMessage_Click);
            URTB.TopicId = topicId;          
            URTB.Enabled = false;
            URTB.RichTextBox.Text = "Veuillez vous autentifiez pour poster des messages";
            
            RTBList.Add(URTB);
            return URTB;
        }

        public void OnConnected(object sender, EventArgs e)
        {
            if (Connected != null)
                Connected(this, e);
            foreach (UcRichTextBox richTextBox in RTBList)
            {
                richTextBox.RichTextBox.Text = "";
                richTextBox.Enabled = true;
            }
        }

        /// <summary>
        /// Build and send the message in DB
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddMessage_Click(object sender, EventArgs e)
        {
            UcRichTextBox ucRichTextBoxReply = (UcRichTextBox)sender;
            AddMessageDB(ucRichTextBoxReply);
            ucRichTextBoxReply.RichTextBox.Text = "";
            // Reload message after add
            if (MessageAdd != null)
                MessageAdd(this, e);
        }

        private void AddMessageDB(UcRichTextBox ucRTBMessage)
        {
            Message = new Message();
            Message.ReplyContent = ucRTBMessage.RichTextBox.Text;
            Message.Topic.TopicId = ucRTBMessage.TopicId;
            Message.Person = PersonConnected;
            //message.TypeReply = ucRTBMessage.

            Controller.AddNewTopicReply(Message);
        }
    }
}
