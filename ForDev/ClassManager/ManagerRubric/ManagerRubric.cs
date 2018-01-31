using BusinessClassPortable;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace ForDev
{
    /// <summary>
    /// Class ManagerRubric
    /// </summary>
    public class ManagerRubric
    {
        public event EventHandler<LoadRubricEventArgs> RubrickClick;
        public List<UcRubric> UCRubricsList = new List<UcRubric>();
        /// <summary>
        /// Business class to build a ManagerRubric
        /// </summary>
        public ManagerRubric()
        {
            List<Rubric> RubricsList = Controller.GetListRubrics();
            AddRubricInList(RubricsList);
        }

        /// <summary>
        /// Build rubric header
        /// </summary>
        /// <returns>user control rubric</returns>
        private UcRubric HeaderRubric()
        {
            UcRubric UCRubricHeader = new UcRubric();
            UCRubricHeader.IconRubric.Image = new Bitmap(Properties.Resources.IconForDev);
            UCRubricHeader.LabelRubric.Text = Properties.Resources.RUBRIC;
            UCRubricHeader.LabelRubric.Font = new Font(UCRubricHeader.LabelRubric.Font, FontStyle.Bold);
            UCRubricHeader.LabelRubric.Font = new Font(UCRubricHeader.Font.FontFamily, 20);
            return UCRubricHeader;
        }

        /// <summary>
        /// Add the rubric to the list
        /// </summary>
        /// <param name="RubricList"></param>
        private void AddRubricInList(List<Rubric> RubricList)
        {
            UCRubricsList.Add(HeaderRubric());
            foreach (Rubric rubric in RubricList)
            {
                UcRubric UCRubric = new UcRubric();
                // switch to add the logo of the rubric
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
                        UCRubric.IconRubric.Image = new Bitmap(Properties.Resources.IconForDev);
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
        /// <param name="sender">user control rubric</param>
        /// <param name="e"></param>
        private void Rubric_Click(object sender, EventArgs e)
        {
            UcRubric UcRubric = (UcRubric)sender;
            if (RubrickClick != null)
                RubrickClick(this, new LoadRubricEventArgs {UcRubric = UcRubric});
        }        
    }
}
