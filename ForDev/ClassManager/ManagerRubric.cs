using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessClass;

namespace ForDev
{
    public class ManagerRubric
    {
        public event EventHandler RubrickClick;
        public Controller Controller = new Controller();
        public List<UcRubric> UCRubricsList = new List<UcRubric>();
        public ManagerRubric()
        {
            List<Rubric> RubricsList = Controller.GetListRubrics();
            AddRubricInList(RubricsList);
        }

        private UcRubric HeaderRubric()
        {
            UcRubric UCRubricHeader = new UcRubric();
            UCRubricHeader.IconRubric.Image = new Bitmap(Properties.Resources.logoForDevjpg);
            UCRubricHeader.LabelRubric.Text = "Rubrique";
            UCRubricHeader.LabelRubric.Font = new Font(UCRubricHeader.LabelRubric.Font, FontStyle.Bold);
            UCRubricHeader.LabelRubric.Font = new Font(UCRubricHeader.Font.FontFamily, 20);

            return UCRubricHeader;
        }
        private void AddRubricInList(List<Rubric> RubricList)
        {
            UCRubricsList.Add(HeaderRubric());
            foreach (Rubric rubric in RubricList)
            {
                UcRubric UCRubric = new UcRubric();
                switch (rubric.RubricId)
                {
                    case 1:
                        UCRubric.IconRubric.Image = new Bitmap(Properties.Resources.development);
                        break;
                    case 2:
                        UCRubric.IconRubric.Image = new Bitmap(Properties.Resources.link);
                        break;
                    case 3:
                        UCRubric.IconRubric.Image = new Bitmap(Properties.Resources.question);
                        break;
                    case 4:
                        UCRubric.IconRubric.Image = new Bitmap(Properties.Resources.relaxation);
                        break;
                    default:
                        UCRubric.IconRubric.Image = new Bitmap(Properties.Resources.logoForDevjpg);
                        break;
                }
                UCRubric.RubricId = rubric.RubricId;
                UCRubric.LabelRubric.Text = rubric.Title;
                UCRubric.ClickRubric += new EventHandler(Rubric_Click);

                UCRubricsList.Add(UCRubric);
            }
        }

        /// <summary>
        /// Uses the method of building topics during the click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Rubric_Click(object sender, EventArgs e)
        {
            MyEventArgs f = new MyEventArgs();
            f.EventArgsRubric = (UcRubric)sender;
            if (RubrickClick != null)
                RubrickClick(this, f);
        }
    }
}
