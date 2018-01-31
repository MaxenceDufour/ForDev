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
    public partial class UcFormProfil : UserControl
    {
        public EventHandler UpdateClick;
        public UcFormProfil()
        {
            InitializeComponent();
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

        public TextBox Email
        {
            get { return textBoxEmail; }
            set { textBoxEmail = value; }
        }

        public TextBox Pass
        {
            get { return textBoxPass; }
            set { textBoxPass = value; }
        }

        public TextBox NewPass1
        {
            get { return textBoxNewPass1; }
            set { textBoxNewPass1 = value; }
        }

        public TextBox NewPass2
        {
            get { return textBoxNewPass2; }
            set { textBoxNewPass2 = value; }
        }

        public PictureBox ProfPictureBox
        {
            get { return pictureBoxProfil; }
            set { pictureBoxProfil = value; }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (UpdateClick != null)
                UpdateClick(this, e);
        }
    }
}
