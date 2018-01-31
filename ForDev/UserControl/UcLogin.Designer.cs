namespace ForDev
{
    partial class UcLogin
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelPass = new System.Windows.Forms.Label();
            this.labelPseudo = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.buttonLogIn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.labelPass, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelPseudo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxLogin, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxPass, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonLogIn, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 11F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(233, 79);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelPass
            // 
            this.labelPass.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelPass.AutoSize = true;
            this.labelPass.Location = new System.Drawing.Point(16, 32);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(35, 13);
            this.labelPass.TabIndex = 3;
            this.labelPass.Text = "pass :";
            // 
            // labelPseudo
            // 
            this.labelPseudo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelPseudo.AutoSize = true;
            this.labelPseudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPseudo.Location = new System.Drawing.Point(3, 6);
            this.labelPseudo.Name = "labelPseudo";
            this.labelPseudo.Size = new System.Drawing.Size(48, 13);
            this.labelPseudo.TabIndex = 0;
            this.labelPseudo.Text = "pseudo :";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxLogin.Location = new System.Drawing.Point(57, 3);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(173, 20);
            this.textBoxLogin.TabIndex = 1;
            // 
            // textBoxPass
            // 
            this.textBoxPass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxPass.Location = new System.Drawing.Point(57, 29);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.PasswordChar = '*';
            this.textBoxPass.Size = new System.Drawing.Size(173, 20);
            this.textBoxPass.TabIndex = 2;
            // 
            // buttonLogIn
            // 
            this.buttonLogIn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonLogIn.Location = new System.Drawing.Point(155, 55);
            this.buttonLogIn.Name = "buttonLogIn";
            this.buttonLogIn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonLogIn.Size = new System.Drawing.Size(75, 21);
            this.buttonLogIn.TabIndex = 3;
            this.buttonLogIn.Text = "&logIn";
            this.buttonLogIn.UseVisualStyleBackColor = true;
            this.buttonLogIn.Click += new System.EventHandler(this.LogIn_Click);
            // 
            // UcLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UcLogin";
            this.Size = new System.Drawing.Size(233, 79);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelPseudo;
        private System.Windows.Forms.Label labelPass;
        public System.Windows.Forms.TextBox textBoxLogin;
        public System.Windows.Forms.TextBox textBoxPass;
        public System.Windows.Forms.Button buttonLogIn;
    }
}
