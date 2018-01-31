using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserEditor;

namespace ForDev
{
    public partial class UcAddTopic : UserControl
    {
        public event EventHandler SendClick;

        public UcAddTopic()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Recovers the propagation of the click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RTBContenu_Load(object sender, EventArgs e)
        {
            if (SendClick != null)
                SendClick(this, e);
        }
        /// <summary>
        /// Initialize the form according to the position of the radio button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RBQuestion_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonClassical.Checked)
            {
                labelTitle.Text = "Titre du topic";
                labelDescription.Visible = true;
                textBoxDescription.Visible = true;
                textBoxDescription.Enabled = true;
                labelContent.Text = "Contenu";
            }
            if (radioButtonQuestion.Checked)
            {
                labelTitle.Text = "Posez votre question";
                labelDescription.Visible = false;
                textBoxDescription.Visible = false;
                textBoxDescription.Enabled = false;
                labelContent.Text = "Développer les besoins lié à votre question";
            }
        }
    }
}
