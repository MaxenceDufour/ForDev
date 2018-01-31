namespace ForDev
{
    partial class UcTopic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcTopic));
            this.content = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelTiles = new System.Windows.Forms.TableLayoutPanel();
            this.rubricPict = new System.Windows.Forms.PictureBox();
            this.description = new System.Windows.Forms.TextBox();
            this.authorDateCreate = new System.Windows.Forms.TextBox();
            this.pictureBoxEdit = new System.Windows.Forms.PictureBox();
            this.pictureBoxDelete = new System.Windows.Forms.PictureBox();
            this.pictureBoxCancel = new System.Windows.Forms.PictureBox();
            this.pictureBoxAccept = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanelTiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rubricPict)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAccept)).BeginInit();
            this.SuspendLayout();
            // 
            // content
            // 
            this.content.BackColor = System.Drawing.SystemColors.Window;
            this.content.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.content.Location = new System.Drawing.Point(43, 12);
            this.content.Margin = new System.Windows.Forms.Padding(5, 12, 0, 0);
            this.content.Multiline = true;
            this.content.Name = "content";
            this.content.ReadOnly = true;
            this.content.Size = new System.Drawing.Size(285, 32);
            this.content.TabIndex = 1;
            this.content.Text = "Content";
            this.content.Click += new System.EventHandler(this.Topic_Click);
            // 
            // tableLayoutPanelTiles
            // 
            this.tableLayoutPanelTiles.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanelTiles.ColumnCount = 8;
            this.tableLayoutPanelTiles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanelTiles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelTiles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelTiles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelTiles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanelTiles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanelTiles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanelTiles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanelTiles.Controls.Add(this.rubricPict, 0, 0);
            this.tableLayoutPanelTiles.Controls.Add(this.description, 2, 0);
            this.tableLayoutPanelTiles.Controls.Add(this.authorDateCreate, 3, 0);
            this.tableLayoutPanelTiles.Controls.Add(this.pictureBoxEdit, 4, 0);
            this.tableLayoutPanelTiles.Controls.Add(this.pictureBoxDelete, 5, 0);
            this.tableLayoutPanelTiles.Controls.Add(this.pictureBoxCancel, 7, 0);
            this.tableLayoutPanelTiles.Controls.Add(this.pictureBoxAccept, 6, 0);
            this.tableLayoutPanelTiles.Controls.Add(this.content, 1, 0);
            this.tableLayoutPanelTiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelTiles.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelTiles.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelTiles.Name = "tableLayoutPanelTiles";
            this.tableLayoutPanelTiles.RowCount = 1;
            this.tableLayoutPanelTiles.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelTiles.Size = new System.Drawing.Size(1064, 42);
            this.tableLayoutPanelTiles.TabIndex = 2;
            this.tableLayoutPanelTiles.Click += new System.EventHandler(this.Topic_Click);
            // 
            // rubricPict
            // 
            this.rubricPict.Image = global::ForDev.Properties.Resources.IconForDev;
            this.rubricPict.Location = new System.Drawing.Point(3, 5);
            this.rubricPict.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.rubricPict.Name = "rubricPict";
            this.rubricPict.Size = new System.Drawing.Size(32, 32);
            this.rubricPict.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rubricPict.TabIndex = 0;
            this.rubricPict.TabStop = false;
            this.rubricPict.Click += new System.EventHandler(this.Topic_Click);
            // 
            // description
            // 
            this.description.BackColor = System.Drawing.Color.White;
            this.description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.description.Dock = System.Windows.Forms.DockStyle.Fill;
            this.description.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.Location = new System.Drawing.Point(333, 12);
            this.description.Margin = new System.Windows.Forms.Padding(5, 12, 0, 0);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Size = new System.Drawing.Size(285, 32);
            this.description.TabIndex = 2;
            this.description.Text = "Description";
            this.description.Click += new System.EventHandler(this.Topic_Click);
            // 
            // authorDateCreate
            // 
            this.authorDateCreate.BackColor = System.Drawing.Color.White;
            this.authorDateCreate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.authorDateCreate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.authorDateCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorDateCreate.Location = new System.Drawing.Point(623, 12);
            this.authorDateCreate.Margin = new System.Windows.Forms.Padding(5, 12, 0, 0);
            this.authorDateCreate.Multiline = true;
            this.authorDateCreate.Name = "authorDateCreate";
            this.authorDateCreate.ReadOnly = true;
            this.authorDateCreate.Size = new System.Drawing.Size(285, 32);
            this.authorDateCreate.TabIndex = 3;
            this.authorDateCreate.Text = "Ajoué par, le...";
            this.authorDateCreate.Click += new System.EventHandler(this.Topic_Click);
            // 
            // pictureBoxEdit
            // 
            this.pictureBoxEdit.Enabled = false;
            this.pictureBoxEdit.Image = global::ForDev.Properties.Resources.drawing;
            this.pictureBoxEdit.Location = new System.Drawing.Point(911, 5);
            this.pictureBoxEdit.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.pictureBoxEdit.Name = "pictureBoxEdit";
            this.pictureBoxEdit.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxEdit.TabIndex = 4;
            this.pictureBoxEdit.TabStop = false;
            this.pictureBoxEdit.Visible = false;
            this.pictureBoxEdit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // pictureBoxDelete
            // 
            this.pictureBoxDelete.Enabled = false;
            this.pictureBoxDelete.Image = global::ForDev.Properties.Resources.delete;
            this.pictureBoxDelete.Location = new System.Drawing.Point(949, 5);
            this.pictureBoxDelete.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.pictureBoxDelete.Name = "pictureBoxDelete";
            this.pictureBoxDelete.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxDelete.TabIndex = 5;
            this.pictureBoxDelete.TabStop = false;
            this.pictureBoxDelete.Visible = false;
            this.pictureBoxDelete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // pictureBoxCancel
            // 
            this.pictureBoxCancel.Enabled = false;
            this.pictureBoxCancel.Image = global::ForDev.Properties.Resources.cancel;
            this.pictureBoxCancel.Location = new System.Drawing.Point(1025, 5);
            this.pictureBoxCancel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.pictureBoxCancel.Name = "pictureBoxCancel";
            this.pictureBoxCancel.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxCancel.TabIndex = 6;
            this.pictureBoxCancel.TabStop = false;
            this.pictureBoxCancel.Visible = false;
            this.pictureBoxCancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // pictureBoxAccept
            // 
            this.pictureBoxAccept.Enabled = false;
            this.pictureBoxAccept.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAccept.Image")));
            this.pictureBoxAccept.Location = new System.Drawing.Point(987, 5);
            this.pictureBoxAccept.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.pictureBoxAccept.Name = "pictureBoxAccept";
            this.pictureBoxAccept.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxAccept.TabIndex = 7;
            this.pictureBoxAccept.TabStop = false;
            this.pictureBoxAccept.Visible = false;
            this.pictureBoxAccept.Click += new System.EventHandler(this.Accept_Click);
            // 
            // UcTopic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanelTiles);
            this.Name = "UcTopic";
            this.Size = new System.Drawing.Size(1064, 42);
            this.tableLayoutPanelTiles.ResumeLayout(false);
            this.tableLayoutPanelTiles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rubricPict)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAccept)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox rubricPict;
        public System.Windows.Forms.TextBox content;
        public System.Windows.Forms.TextBox description;
        public System.Windows.Forms.TextBox authorDateCreate;
        public System.Windows.Forms.PictureBox pictureBoxEdit;
        public System.Windows.Forms.PictureBox pictureBoxDelete;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanelTiles;
        public System.Windows.Forms.PictureBox pictureBoxCancel;
        public System.Windows.Forms.PictureBox pictureBoxAccept;
    }
}
