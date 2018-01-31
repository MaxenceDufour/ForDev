using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForDev
{
    public partial class UcLogged : UserControl
    {
        public event EventHandler ProfilClick;
        public event EventHandler LogOutClick;
        public event EventHandler TopicAdd;
        public event EventHandler VisibleChanged;
        public UcLogged()
        {
            InitializeComponent();
            this.Dock = DockStyle.Top;
        }

        public TextBox FirstName
        {
            get { return textBoxFirstName; }
            set { textBoxFirstName = value; }
        }

        public TextBox LastName
        {
            get { return textBoxLastName; }
            set { textBoxLastName = value; }
        }

        private void Profil_Click(object sender, EventArgs e)
        {
            if (ProfilClick != null)
                ProfilClick(this, e);
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            if (LogOutClick != null)
                LogOutClick(this, e);
        }

        private void AddTopic_Click(object sender, EventArgs e)
        {
            if (TopicAdd != null)
                TopicAdd(this, e);
        }
    }
}
