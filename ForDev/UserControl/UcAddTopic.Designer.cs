namespace ForDev
{
    partial class UcAddTopic
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanelFormTopic = new System.Windows.Forms.TableLayoutPanel();
            this.panelContentClassical = new System.Windows.Forms.Panel();
            this.UcRichTextBoxAddTopic = new UserEditor.UcRichTextBox();
            this.labelContent = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanelType = new System.Windows.Forms.TableLayoutPanel();
            this.panelTypeTopic = new System.Windows.Forms.Panel();
            this.radioButtonSurvey = new System.Windows.Forms.RadioButton();
            this.radioButtonQuestion = new System.Windows.Forms.RadioButton();
            this.radioButtonClassical = new System.Windows.Forms.RadioButton();
            this.labelTypeTopic = new System.Windows.Forms.Label();
            this.panelTypeRubric = new System.Windows.Forms.Panel();
            this.comboBoxRubric = new System.Windows.Forms.ComboBox();
            this.labelRubric = new System.Windows.Forms.Label();
            this.tableLayoutPanelFormTopic.SuspendLayout();
            this.panelContentClassical.SuspendLayout();
            this.tableLayoutPanelType.SuspendLayout();
            this.panelTypeTopic.SuspendLayout();
            this.panelTypeRubric.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelFormTopic
            // 
            this.tableLayoutPanelFormTopic.ColumnCount = 1;
            this.tableLayoutPanelFormTopic.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelFormTopic.Controls.Add(this.panelContentClassical, 0, 1);
            this.tableLayoutPanelFormTopic.Controls.Add(this.tableLayoutPanelType, 0, 0);
            this.tableLayoutPanelFormTopic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelFormTopic.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelFormTopic.Name = "tableLayoutPanelFormTopic";
            this.tableLayoutPanelFormTopic.RowCount = 2;
            this.tableLayoutPanelFormTopic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanelFormTopic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelFormTopic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelFormTopic.Size = new System.Drawing.Size(659, 598);
            this.tableLayoutPanelFormTopic.TabIndex = 0;
            // 
            // panelContentClassical
            // 
            this.panelContentClassical.Controls.Add(this.UcRichTextBoxAddTopic);
            this.panelContentClassical.Controls.Add(this.labelContent);
            this.panelContentClassical.Controls.Add(this.textBoxDescription);
            this.panelContentClassical.Controls.Add(this.labelDescription);
            this.panelContentClassical.Controls.Add(this.textBoxTitle);
            this.panelContentClassical.Controls.Add(this.labelTitle);
            this.panelContentClassical.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContentClassical.Location = new System.Drawing.Point(0, 49);
            this.panelContentClassical.Margin = new System.Windows.Forms.Padding(0);
            this.panelContentClassical.Name = "panelContentClassical";
            this.panelContentClassical.Size = new System.Drawing.Size(659, 549);
            this.panelContentClassical.TabIndex = 1;
            // 
            // UcRichTextBoxAddTopic
            // 
            this.UcRichTextBoxAddTopic.AutoSize = true;
            this.UcRichTextBoxAddTopic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UcRichTextBoxAddTopic.Enabled = false;
            this.UcRichTextBoxAddTopic.Location = new System.Drawing.Point(0, 128);
            this.UcRichTextBoxAddTopic.Name = "UcRichTextBoxAddTopic";
            this.UcRichTextBoxAddTopic.Size = new System.Drawing.Size(659, 421);
            this.UcRichTextBoxAddTopic.SplitContainer = null;
            this.UcRichTextBoxAddTopic.TabIndex = 7;
            this.UcRichTextBoxAddTopic.TopicId = 0;
            this.UcRichTextBoxAddTopic.Load += new System.EventHandler(this.RTBContenu_Load);
            // 
            // labelContent
            // 
            this.labelContent.AutoSize = true;
            this.labelContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelContent.Location = new System.Drawing.Point(0, 110);
            this.labelContent.Name = "labelContent";
            this.labelContent.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.labelContent.Size = new System.Drawing.Size(53, 18);
            this.labelContent.TabIndex = 4;
            this.labelContent.Text = "Contenu :";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxDescription.Location = new System.Drawing.Point(0, 56);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(659, 54);
            this.textBoxDescription.TabIndex = 6;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelDescription.Location = new System.Drawing.Point(0, 38);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.labelDescription.Size = new System.Drawing.Size(66, 18);
            this.labelDescription.TabIndex = 2;
            this.labelDescription.Text = "Description :";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxTitle.Location = new System.Drawing.Point(0, 18);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(659, 20);
            this.textBoxTitle.TabIndex = 5;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.labelTitle.Size = new System.Drawing.Size(34, 18);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Titre :";
            // 
            // tableLayoutPanelType
            // 
            this.tableLayoutPanelType.ColumnCount = 2;
            this.tableLayoutPanelType.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.03982F));
            this.tableLayoutPanelType.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.96018F));
            this.tableLayoutPanelType.Controls.Add(this.panelTypeTopic, 0, 0);
            this.tableLayoutPanelType.Controls.Add(this.panelTypeRubric, 1, 0);
            this.tableLayoutPanelType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelType.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelType.Name = "tableLayoutPanelType";
            this.tableLayoutPanelType.RowCount = 1;
            this.tableLayoutPanelType.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelType.Size = new System.Drawing.Size(653, 43);
            this.tableLayoutPanelType.TabIndex = 6;
            // 
            // panelTypeTopic
            // 
            this.panelTypeTopic.Controls.Add(this.radioButtonSurvey);
            this.panelTypeTopic.Controls.Add(this.radioButtonQuestion);
            this.panelTypeTopic.Controls.Add(this.radioButtonClassical);
            this.panelTypeTopic.Controls.Add(this.labelTypeTopic);
            this.panelTypeTopic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTypeTopic.Location = new System.Drawing.Point(0, 0);
            this.panelTypeTopic.Margin = new System.Windows.Forms.Padding(0);
            this.panelTypeTopic.Name = "panelTypeTopic";
            this.panelTypeTopic.Size = new System.Drawing.Size(379, 43);
            this.panelTypeTopic.TabIndex = 0;
            // 
            // radioButtonSurvey
            // 
            this.radioButtonSurvey.AutoSize = true;
            this.radioButtonSurvey.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioButtonSurvey.Enabled = false;
            this.radioButtonSurvey.Location = new System.Drawing.Point(186, 18);
            this.radioButtonSurvey.Name = "radioButtonSurvey";
            this.radioButtonSurvey.Size = new System.Drawing.Size(127, 25);
            this.radioButtonSurvey.TabIndex = 3;
            this.radioButtonSurvey.Text = "Effectuer un sondage";
            this.radioButtonSurvey.UseVisualStyleBackColor = true;
            this.radioButtonSurvey.Visible = false;
            // 
            // radioButtonQuestion
            // 
            this.radioButtonQuestion.AutoSize = true;
            this.radioButtonQuestion.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioButtonQuestion.Location = new System.Drawing.Point(70, 18);
            this.radioButtonQuestion.Name = "radioButtonQuestion";
            this.radioButtonQuestion.Size = new System.Drawing.Size(116, 25);
            this.radioButtonQuestion.TabIndex = 2;
            this.radioButtonQuestion.Text = "Poser une question";
            this.radioButtonQuestion.UseVisualStyleBackColor = true;
            this.radioButtonQuestion.CheckedChanged += new System.EventHandler(this.RBQuestion_CheckedChanged);
            // 
            // radioButtonClassical
            // 
            this.radioButtonClassical.AutoSize = true;
            this.radioButtonClassical.Checked = true;
            this.radioButtonClassical.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioButtonClassical.Location = new System.Drawing.Point(0, 18);
            this.radioButtonClassical.Name = "radioButtonClassical";
            this.radioButtonClassical.Size = new System.Drawing.Size(70, 25);
            this.radioButtonClassical.TabIndex = 1;
            this.radioButtonClassical.TabStop = true;
            this.radioButtonClassical.Text = "Classique";
            this.radioButtonClassical.UseVisualStyleBackColor = true;
            // 
            // labelTypeTopic
            // 
            this.labelTypeTopic.AutoSize = true;
            this.labelTypeTopic.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTypeTopic.Location = new System.Drawing.Point(0, 0);
            this.labelTypeTopic.Name = "labelTypeTopic";
            this.labelTypeTopic.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.labelTypeTopic.Size = new System.Drawing.Size(186, 18);
            this.labelTypeTopic.TabIndex = 0;
            this.labelTypeTopic.Text = "Quel type de topic voulez-vous créer?";
            // 
            // panelTypeRubric
            // 
            this.panelTypeRubric.Controls.Add(this.comboBoxRubric);
            this.panelTypeRubric.Controls.Add(this.labelRubric);
            this.panelTypeRubric.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTypeRubric.Location = new System.Drawing.Point(379, 0);
            this.panelTypeRubric.Margin = new System.Windows.Forms.Padding(0);
            this.panelTypeRubric.Name = "panelTypeRubric";
            this.panelTypeRubric.Size = new System.Drawing.Size(274, 43);
            this.panelTypeRubric.TabIndex = 1;
            // 
            // comboBoxRubric
            // 
            this.comboBoxRubric.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxRubric.FormattingEnabled = true;
            this.comboBoxRubric.Location = new System.Drawing.Point(0, 13);
            this.comboBoxRubric.Name = "comboBoxRubric";
            this.comboBoxRubric.Size = new System.Drawing.Size(274, 21);
            this.comboBoxRubric.TabIndex = 4;
            // 
            // labelRubric
            // 
            this.labelRubric.AutoSize = true;
            this.labelRubric.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelRubric.Location = new System.Drawing.Point(0, 0);
            this.labelRubric.Name = "labelRubric";
            this.labelRubric.Size = new System.Drawing.Size(202, 13);
            this.labelRubric.TabIndex = 0;
            this.labelRubric.Text = "Dans quelle rubrique voulez-vous poster?";
            // 
            // UcAddTopic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanelFormTopic);
            this.Name = "UcAddTopic";
            this.Size = new System.Drawing.Size(659, 598);
            this.tableLayoutPanelFormTopic.ResumeLayout(false);
            this.panelContentClassical.ResumeLayout(false);
            this.panelContentClassical.PerformLayout();
            this.tableLayoutPanelType.ResumeLayout(false);
            this.panelTypeTopic.ResumeLayout(false);
            this.panelTypeTopic.PerformLayout();
            this.panelTypeRubric.ResumeLayout(false);
            this.panelTypeRubric.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelFormTopic;
        private System.Windows.Forms.Panel panelTypeTopic;
        private System.Windows.Forms.Label labelTypeTopic;
        private System.Windows.Forms.Panel panelContentClassical;
        private System.Windows.Forms.Label labelContent;
        public System.Windows.Forms.TextBox textBoxTitle;
        public UserEditor.UcRichTextBox UcRichTextBoxAddTopic;
        public System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelType;
        private System.Windows.Forms.Panel panelTypeRubric;
        private System.Windows.Forms.Label labelRubric;
        public System.Windows.Forms.ComboBox comboBoxRubric;
        public System.Windows.Forms.RadioButton radioButtonSurvey;
        public System.Windows.Forms.RadioButton radioButtonQuestion;
        public System.Windows.Forms.RadioButton radioButtonClassical;
        public System.Windows.Forms.Label labelDescription;
        public System.Windows.Forms.Label labelTitle;
    }
}
