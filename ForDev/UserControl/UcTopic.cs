using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PropertyAttributes = System.Reflection.PropertyAttributes;

namespace ForDev
{
    public partial class UcTopic : UserControl
    {
        public int Id { get; set; }
        public int RubricId { get; set; }
        public event EventHandler ButtonClickTiles;
        public event EventHandler ButtonEditTiles;
        public event EventHandler ButtonDeleteTiles;
        public event EventHandler ButtonValidate;
        public event EventHandler ButtonCanceled;
        public UcTopic()
        {
            InitializeComponent();
            this.Dock = DockStyle.Top;
            Id = 0;
        }

        public TextBox ContentText
        {
            get { return content; }
            set { content = value; }
        }

        public TextBox Description
        {
            get { return description; }
            set { description = value; }
        }

        public TextBox AuthorDateCreate
        {
            get { return authorDateCreate; }
            set { authorDateCreate = value; }
        }

        public PictureBox RubricPictContent
        {
            get { return rubricPict; }
            set { rubricPict = value; }
        }

        public TableLayoutPanel tlp
        {
            get { return tableLayoutPanelTiles; }
            set { tableLayoutPanelTiles = value; }
        }

        private void Topic_Click(object sender, EventArgs e)
        {
            if (ButtonClickTiles != null)
                ButtonClickTiles(this, e);
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (ButtonEditTiles != null)
                ButtonEditTiles(this, e);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (ButtonDeleteTiles != null)
                ButtonDeleteTiles(this, e);
        }

        private void Accept_Click(object sender, EventArgs e)
        {
            if (ButtonValidate != null)
                ButtonValidate(this, e);
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            if (ButtonCanceled != null)
                ButtonCanceled(this, e);
        }
    }
}
