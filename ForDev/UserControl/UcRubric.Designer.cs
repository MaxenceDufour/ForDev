namespace ForDev
{
    partial class UcRubric
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
            this.tableLayoutPanelRubric = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxRubric = new System.Windows.Forms.PictureBox();
            this.labelRubric = new System.Windows.Forms.Label();
            this.tableLayoutPanelRubric.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRubric)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelRubric
            // 
            this.tableLayoutPanelRubric.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanelRubric.ColumnCount = 2;
            this.tableLayoutPanelRubric.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanelRubric.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelRubric.Controls.Add(this.pictureBoxRubric, 0, 0);
            this.tableLayoutPanelRubric.Controls.Add(this.labelRubric, 1, 0);
            this.tableLayoutPanelRubric.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelRubric.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelRubric.Name = "tableLayoutPanelRubric";
            this.tableLayoutPanelRubric.RowCount = 1;
            this.tableLayoutPanelRubric.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanelRubric.Size = new System.Drawing.Size(245, 38);
            this.tableLayoutPanelRubric.TabIndex = 0;
            this.tableLayoutPanelRubric.Click += new System.EventHandler(this.UCRubric_Click);
            // 
            // pictureBoxRubric
            // 
            this.pictureBoxRubric.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxRubric.Name = "pictureBoxRubric";
            this.pictureBoxRubric.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxRubric.TabIndex = 0;
            this.pictureBoxRubric.TabStop = false;
            this.pictureBoxRubric.Click += new System.EventHandler(this.UCRubric_Click);
            // 
            // labelRubric
            // 
            this.labelRubric.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelRubric.AutoSize = true;
            this.labelRubric.BackColor = System.Drawing.Color.White;
            this.labelRubric.Location = new System.Drawing.Point(41, 12);
            this.labelRubric.Name = "labelRubric";
            this.labelRubric.Size = new System.Drawing.Size(38, 13);
            this.labelRubric.TabIndex = 1;
            this.labelRubric.Text = "Rubric";
            this.labelRubric.Click += new System.EventHandler(this.UCRubric_Click);
            // 
            // UcRubric
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanelRubric);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UcRubric";
            this.Size = new System.Drawing.Size(245, 38);
            this.tableLayoutPanelRubric.ResumeLayout(false);
            this.tableLayoutPanelRubric.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRubric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.PictureBox pictureBoxRubric;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanelRubric;
        public System.Windows.Forms.Label labelRubric;
    }
}
