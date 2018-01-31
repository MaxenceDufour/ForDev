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
    public partial class UcLogin : UserControl
    {
        public EventHandler ButtonClick;

        public UcLogin()
        {
            InitializeComponent();
        }
        
        public TextBox LoginTextBox
        {
            get { return textBoxLogin; }
            set { textBoxLogin = value; }
        }

        public TextBox PassTextBox
        {
            get { return textBoxPass; }
            set { textBoxPass = value; }
        }

        private void LogIn_Click(object sender, EventArgs e)
        {
            if (ButtonClick != null)
                ButtonClick(this, e);
        }
    }
}
