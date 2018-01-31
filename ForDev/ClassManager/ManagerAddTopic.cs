using ForDev.ClassManager.ManagerLogin;
using System;
using System.Windows.Forms;
using BusinessClassPortable;

namespace ForDev
{
    /// <summary>
    /// Class ManagerTopic
    /// </summary>
    public class ManagerAddTopic
    {
        private bool _connection;
        private Person _personConnected;

        public event EventHandler ButtonAddTopic;
        public UcAddTopic UcAddTopic { get; set; } = new UcAddTopic();
        public Rubric Rubric;

        /// <summary>
        /// Dinamically constructed form for add topic
        /// </summary>
        public void BuildAddTopic()
        {
            UcAddTopic.comboBoxRubric.Name = Properties.Resources.COMBOBOXRUBRIC;
            UcAddTopic.comboBoxRubric.DataSource = Controller.GetListRubrics();
            UcAddTopic.comboBoxRubric.DisplayMember = Properties.Resources.TITLE;
            UcAddTopic.comboBoxRubric.ValueMember = Properties.Resources.RUBRICID;
            UcAddTopic.UcRichTextBoxAddTopic.btnSend.Click += new EventHandler(AddTopic_Click);
        }

        /// <summary>
        /// Modify the behavior after connection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">object person</param>
        public void OnConnected(object sender, PersonConnectedEventArgs e)
        {
            _personConnected = e.PersonConnected;
            _connection = true;
            UcAddTopic.UcRichTextBoxAddTopic.Enabled = true;
            UcAddTopic.UcRichTextBoxAddTopic.RichTextBox.Text = Properties.Resources.EMPTY;
            BuildAddTopic();
        }

        /// <summary>
        /// Modifies the behavior after disconnection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnDisconnected(object sender, EventArgs e)
        {
            _connection = false;
            UcAddTopic.UcRichTextBoxAddTopic.btnSend.Click -= new EventHandler(AddTopic_Click);
        }

        /// <summary>
        /// Check and add the topic to the db
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void AddTopic_Click(object sender, EventArgs e)
        {
            if (UcAddTopic.textBoxTitle.Text == Properties.Resources.EMPTY || UcAddTopic.UcRichTextBoxAddTopic.RichTextBox.Text == Properties.Resources.EMPTY)
            {
                MessageBox.Show(Properties.Resources.EMPTYFIELDS, Properties.Resources.CAPTIONEMPTYFIELDS, MessageBoxButtons.OK);
                return;
            }
            if (UcAddTopic.textBoxDescription.Text == Properties.Resources.EMPTY)
                UcAddTopic.textBoxDescription.Text = UcAddTopic.textBoxTitle.Text;

            Topic newTopic = null;

            //Linq methode
            //Rubric = rubricList.FirstOrDefault(j => j.RubricId == Convert.ToInt32(_ucAddTopic.comboBoxRubric.SelectedValue));

            foreach (Rubric rubric in Controller.GetListRubrics())
                if (rubric.RubricId == Convert.ToInt32(UcAddTopic.comboBoxRubric.SelectedValue))
                    Rubric = rubric;

            if (UcAddTopic.radioButtonClassical.Checked)
            {
                newTopic = new Topic(
                    _personConnected,
                    (int)BusinessClassPortable.Enum.TypeTopic.Classical,
                    Rubric,
                    DateTime.Now,
                    UcAddTopic.textBoxDescription.Text,
                    UcAddTopic.UcRichTextBoxAddTopic.RichTextBox.Text,
                    UcAddTopic.textBoxTitle.Text);
            }

            if (UcAddTopic.radioButtonQuestion.Checked)
            {
                newTopic = new Topic(
                    _personConnected,
                    (int)BusinessClassPortable.Enum.TypeTopic.Question,
                    Rubric,
                    DateTime.Now,
                    Properties.Resources.RADIOQUESTION,
                    UcAddTopic.UcRichTextBoxAddTopic.RichTextBox.Text,
                    UcAddTopic.textBoxTitle.Text);
            }

            //if (UcAddTopic.radioButtonSurvey.Checked)

            UcAddTopic.textBoxTitle.Text = Properties.Resources.EMPTY ;
            UcAddTopic.UcRichTextBoxAddTopic.RichTextBox.Text = Properties.Resources.EMPTY;
            UcAddTopic.textBoxDescription.Text = Properties.Resources.EMPTY;

            Controller.CreateTopic(newTopic, _personConnected.PersonId);

            if (ButtonAddTopic != null)
                ButtonAddTopic(this, e);
        }
    }
}
