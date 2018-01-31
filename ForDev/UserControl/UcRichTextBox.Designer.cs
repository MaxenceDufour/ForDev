namespace UserEditor
{
    partial class UcRichTextBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcRichTextBox));
            this.toolCtrlRtf = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonBold = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonItalic = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonUnderline = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonStrikeout = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonColor = new System.Windows.Forms.ToolStripButton();
            this.txtCtrlRch = new System.Windows.Forms.RichTextBox();
            this.colorCtrlRtf = new System.Windows.Forms.ColorDialog();
            this.btnSend = new System.Windows.Forms.Button();
            this.toolCtrlRtf.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolCtrlRtf
            // 
            this.toolCtrlRtf.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonBold,
            this.toolStripButtonItalic,
            this.toolStripButtonUnderline,
            this.toolStripButtonStrikeout,
            this.toolStripSeparator1,
            this.toolStripButtonColor});
            this.toolCtrlRtf.Location = new System.Drawing.Point(0, 0);
            this.toolCtrlRtf.Name = "toolCtrlRtf";
            this.toolCtrlRtf.Size = new System.Drawing.Size(749, 25);
            this.toolCtrlRtf.TabIndex = 1;
            this.toolCtrlRtf.Text = "toolStrip1";
            // 
            // toolStripButtonBold
            // 
            this.toolStripButtonBold.CheckOnClick = true;
            this.toolStripButtonBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonBold.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonBold.Image")));
            this.toolStripButtonBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBold.Name = "toolStripButtonBold";
            this.toolStripButtonBold.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonBold.Text = "toolStripButtonBold";
            this.toolStripButtonBold.Click += new System.EventHandler(this.Bold_Click);
            // 
            // toolStripButtonItalic
            // 
            this.toolStripButtonItalic.CheckOnClick = true;
            this.toolStripButtonItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonItalic.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonItalic.Image")));
            this.toolStripButtonItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonItalic.Name = "toolStripButtonItalic";
            this.toolStripButtonItalic.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonItalic.Text = "toolStripButtonItalic";
            this.toolStripButtonItalic.Click += new System.EventHandler(this.Italic_Click);
            // 
            // toolStripButtonUnderline
            // 
            this.toolStripButtonUnderline.CheckOnClick = true;
            this.toolStripButtonUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonUnderline.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUnderline.Image")));
            this.toolStripButtonUnderline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUnderline.Name = "toolStripButtonUnderline";
            this.toolStripButtonUnderline.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonUnderline.Text = "toolStripButtonUnderline";
            this.toolStripButtonUnderline.Click += new System.EventHandler(this.Underline_Click);
            // 
            // toolStripButtonStrikeout
            // 
            this.toolStripButtonStrikeout.CheckOnClick = true;
            this.toolStripButtonStrikeout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonStrikeout.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonStrikeout.Image")));
            this.toolStripButtonStrikeout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonStrikeout.Name = "toolStripButtonStrikeout";
            this.toolStripButtonStrikeout.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonStrikeout.Text = "toolStripButtonStrikeout";
            this.toolStripButtonStrikeout.Click += new System.EventHandler(this.Strikeout_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonColor
            // 
            this.toolStripButtonColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonColor.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonColor.Image")));
            this.toolStripButtonColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonColor.Name = "toolStripButtonColor";
            this.toolStripButtonColor.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonColor.Text = "toolStripButtonColor";
            this.toolStripButtonColor.ToolTipText = "toolStripButtonColor";
            this.toolStripButtonColor.Click += new System.EventHandler(this.Color_Click);
            // 
            // txtCtrlRch
            // 
            this.txtCtrlRch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCtrlRch.Location = new System.Drawing.Point(0, 25);
            this.txtCtrlRch.Name = "txtCtrlRch";
            this.txtCtrlRch.Size = new System.Drawing.Size(749, 125);
            this.txtCtrlRch.TabIndex = 2;
            this.txtCtrlRch.Text = "Veuillez vous autentifiez pour poster des messages";
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Location = new System.Drawing.Point(671, 124);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "Envoyer";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.Send_Click);
            // 
            // UcRichTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtCtrlRch);
            this.Controls.Add(this.toolCtrlRtf);
            this.Enabled = false;
            this.Name = "UcRichTextBox";
            this.Size = new System.Drawing.Size(749, 150);
            this.toolCtrlRtf.ResumeLayout(false);
            this.toolCtrlRtf.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripButton toolStripButtonItalic;
        private System.Windows.Forms.ToolStripButton toolStripButtonUnderline;
        private System.Windows.Forms.ToolStripButton toolStripButtonStrikeout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonColor;
        private System.Windows.Forms.ColorDialog colorCtrlRtf;
        public System.Windows.Forms.Button btnSend;
        public System.Windows.Forms.RichTextBox txtCtrlRch;
        public System.Windows.Forms.ToolStrip toolCtrlRtf;
        public System.Windows.Forms.ToolStripButton toolStripButtonBold;
    }
}
