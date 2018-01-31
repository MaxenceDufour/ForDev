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
    public partial class UcRubric : UserControl
    {
        public int RubricId { get; set; }

        public event EventHandler ClickRubric;

        public UcRubric()
        {
            InitializeComponent();
        }

        public Label LabelRubric
        {
            get { return labelRubric; }
            set { labelRubric = value; }
        }

        public PictureBox IconRubric
        {
            get { return pictureBoxRubric; }
            set { pictureBoxRubric = value; }
        }

        private void UCRubric_Click(object sender, EventArgs e)
        {
            if (ClickRubric != null)
                ClickRubric(this, e);
        }
    }
}
