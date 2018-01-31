namespace ForDev
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabPageHome = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.labelMessageLog = new System.Windows.Forms.Label();
            this.panelRubric = new System.Windows.Forms.Panel();
            this.panelTopic = new System.Windows.Forms.Panel();
            this.tabControlApp = new System.Windows.Forms.TabControl();
            this.bindingSourceRubric = new System.Windows.Forms.BindingSource(this.components);
            this.tt = new System.Windows.Forms.ToolTip(this.components);
            this.tabPageHome.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.tableLayoutPanel6.SuspendLayout();
            this.tabControlApp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRubric)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPageHome
            // 
            this.tabPageHome.BackColor = System.Drawing.Color.White;
            this.tabPageHome.Controls.Add(this.tableLayoutPanel4);
            this.tabPageHome.Location = new System.Drawing.Point(4, 22);
            this.tabPageHome.Name = "tabPageHome";
            this.tabPageHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHome.Size = new System.Drawing.Size(1051, 701);
            this.tabPageHome.TabIndex = 0;
            this.tabPageHome.Text = "Accueil";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel6, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.27119F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.72881F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1045, 695);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.50265F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.49735F));
            this.tableLayoutPanel5.Controls.Add(this.pictureBoxLogo, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.labelTitle, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1045, 113);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxLogo.Image = global::ForDev.Properties.Resources.logoForDev;
            this.pictureBoxLogo.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(166, 107);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(177, 33);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(414, 46);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Bienvenue sur ForDev";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.27732F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.72268F));
            this.tableLayoutPanel6.Controls.Add(this.labelMessageLog, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.panelRubric, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.panelTopic, 1, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 113);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(1045, 582);
            this.tableLayoutPanel6.TabIndex = 1;
            // 
            // labelMessageLog
            // 
            this.labelMessageLog.AutoSize = true;
            this.labelMessageLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessageLog.Location = new System.Drawing.Point(173, 0);
            this.labelMessageLog.Name = "labelMessageLog";
            this.labelMessageLog.Size = new System.Drawing.Size(311, 13);
            this.labelMessageLog.TabIndex = 1;
            this.labelMessageLog.Text = "Pour acceder à toute les fonctionnalitées, merci de vous identifié";
            // 
            // panelRubric
            // 
            this.panelRubric.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRubric.Location = new System.Drawing.Point(0, 13);
            this.panelRubric.Margin = new System.Windows.Forms.Padding(0);
            this.panelRubric.Name = "panelRubric";
            this.panelRubric.Size = new System.Drawing.Size(170, 569);
            this.panelRubric.TabIndex = 4;
            // 
            // panelTopic
            // 
            this.panelTopic.BackColor = System.Drawing.Color.Transparent;
            this.panelTopic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTopic.Location = new System.Drawing.Point(170, 13);
            this.panelTopic.Margin = new System.Windows.Forms.Padding(0);
            this.panelTopic.Name = "panelTopic";
            this.panelTopic.Size = new System.Drawing.Size(875, 569);
            this.panelTopic.TabIndex = 5;
            // 
            // tabControlApp
            // 
            this.tabControlApp.Controls.Add(this.tabPageHome);
            this.tabControlApp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlApp.Location = new System.Drawing.Point(0, 0);
            this.tabControlApp.Name = "tabControlApp";
            this.tabControlApp.Padding = new System.Drawing.Point(13, 3);
            this.tabControlApp.SelectedIndex = 0;
            this.tabControlApp.Size = new System.Drawing.Size(1059, 727);
            this.tabControlApp.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControlApp.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1059, 727);
            this.Controls.Add(this.tabControlApp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MinimumSize = new System.Drawing.Size(1075, 766);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForDev";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.tabPageHome.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tabControlApp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRubric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPageHome;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.TabControl tabControlApp;
        private System.Windows.Forms.Label labelMessageLog;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.BindingSource bindingSourceRubric;
        private System.Windows.Forms.ToolTip tt;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Panel panelRubric;
        private System.Windows.Forms.Panel panelTopic;
    }
}