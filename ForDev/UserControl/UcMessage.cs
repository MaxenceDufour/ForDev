using BusinessClassPortable;
using System;
using System.Windows.Forms;

namespace ForDev
{
    public partial class UcMessage : UserControl
    {
        public event EventHandler PlusClick;
        public event EventHandler DeleteClick;
        public int AuthorId { get; set; }
        public int TopicReplyId { get; set; }
        public Topic Topic { get; set; } = new Topic();
        
        public UcMessage()
        {
            InitializeComponent();
            this.Dock = DockStyle.Top;
        }

        public RichTextBox ContentText
        {
            get { return richTextBoxMessage; }
            set { richTextBoxMessage = value; }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (DeleteClick != null)
                DeleteClick(this, e);
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            if (PlusClick != null)
                PlusClick(this, e);
        }
    }
}
