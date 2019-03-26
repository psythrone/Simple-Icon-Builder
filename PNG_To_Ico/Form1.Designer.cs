namespace PNG_To_Ico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSave = new System.Windows.Forms.Button();
            this.sfdIcon = new System.Windows.Forms.SaveFileDialog();
            this.pbIcon128px = new System.Windows.Forms.PictureBox();
            this.pbIcon64px = new System.Windows.Forms.PictureBox();
            this.pbIcon24px = new System.Windows.Forms.PictureBox();
            this.pbIcon32px = new System.Windows.Forms.PictureBox();
            this.pbIcon48px = new System.Windows.Forms.PictureBox();
            this.pbIcon16px = new System.Windows.Forms.PictureBox();
            this.pIcon128px = new System.Windows.Forms.Panel();
            this.pIcon64px = new System.Windows.Forms.Panel();
            this.pIcon48px = new System.Windows.Forms.Panel();
            this.pIcon32px = new System.Windows.Forms.Panel();
            this.pIcon24px = new System.Windows.Forms.Panel();
            this.pIcon16px = new System.Windows.Forms.Panel();
            this.btnHelp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon128px)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon64px)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon24px)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon32px)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon48px)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon16px)).BeginInit();
            this.pIcon128px.SuspendLayout();
            this.pIcon64px.SuspendLayout();
            this.pIcon48px.SuspendLayout();
            this.pIcon32px.SuspendLayout();
            this.pIcon24px.SuspendLayout();
            this.pIcon16px.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(295, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(115, 60);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save Icon";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // sfdIcon
            // 
            this.sfdIcon.FileName = "Icon";
            this.sfdIcon.Filter = "Icon|*.ico";
            this.sfdIcon.Title = "Save Icon";
            this.sfdIcon.FileOk += new System.ComponentModel.CancelEventHandler(this.sfdIcon_FileOk);
            // 
            // pbIcon128px
            // 
            this.pbIcon128px.Image = global::PNG_To_Ico.Properties.Resources.PNG128px;
            this.pbIcon128px.Location = new System.Drawing.Point(3, 3);
            this.pbIcon128px.Name = "pbIcon128px";
            this.pbIcon128px.Size = new System.Drawing.Size(128, 128);
            this.pbIcon128px.TabIndex = 3;
            this.pbIcon128px.TabStop = false;
            this.pbIcon128px.Click += new System.EventHandler(this.pbIcon128px_Click);
            // 
            // pbIcon64px
            // 
            this.pbIcon64px.Image = global::PNG_To_Ico.Properties.Resources.PNG64px;
            this.pbIcon64px.Location = new System.Drawing.Point(3, 3);
            this.pbIcon64px.Name = "pbIcon64px";
            this.pbIcon64px.Size = new System.Drawing.Size(64, 64);
            this.pbIcon64px.TabIndex = 1;
            this.pbIcon64px.TabStop = false;
            this.pbIcon64px.Click += new System.EventHandler(this.pbIcon64px_Click);
            // 
            // pbIcon24px
            // 
            this.pbIcon24px.Image = global::PNG_To_Ico.Properties.Resources.PNG24px;
            this.pbIcon24px.Location = new System.Drawing.Point(3, 3);
            this.pbIcon24px.Name = "pbIcon24px";
            this.pbIcon24px.Size = new System.Drawing.Size(24, 24);
            this.pbIcon24px.TabIndex = 1;
            this.pbIcon24px.TabStop = false;
            this.pbIcon24px.Click += new System.EventHandler(this.pbIcon24px_Click);
            // 
            // pbIcon32px
            // 
            this.pbIcon32px.Image = global::PNG_To_Ico.Properties.Resources.PNG32px;
            this.pbIcon32px.Location = new System.Drawing.Point(3, 3);
            this.pbIcon32px.Name = "pbIcon32px";
            this.pbIcon32px.Size = new System.Drawing.Size(32, 32);
            this.pbIcon32px.TabIndex = 1;
            this.pbIcon32px.TabStop = false;
            this.pbIcon32px.Click += new System.EventHandler(this.pbIcon32px_Click);
            // 
            // pbIcon48px
            // 
            this.pbIcon48px.Image = global::PNG_To_Ico.Properties.Resources.PNG48px;
            this.pbIcon48px.Location = new System.Drawing.Point(3, 3);
            this.pbIcon48px.Name = "pbIcon48px";
            this.pbIcon48px.Size = new System.Drawing.Size(48, 48);
            this.pbIcon48px.TabIndex = 1;
            this.pbIcon48px.TabStop = false;
            this.pbIcon48px.Click += new System.EventHandler(this.pbIcon48px_Click);
            // 
            // pbIcon16px
            // 
            this.pbIcon16px.Image = global::PNG_To_Ico.Properties.Resources.PNG16px;
            this.pbIcon16px.Location = new System.Drawing.Point(3, 3);
            this.pbIcon16px.Name = "pbIcon16px";
            this.pbIcon16px.Size = new System.Drawing.Size(16, 16);
            this.pbIcon16px.TabIndex = 0;
            this.pbIcon16px.TabStop = false;
            this.pbIcon16px.Click += new System.EventHandler(this.pbIcon16px_Click);
            // 
            // pIcon128px
            // 
            this.pIcon128px.AutoSize = true;
            this.pIcon128px.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pIcon128px.BackColor = System.Drawing.SystemColors.Control;
            this.pIcon128px.Controls.Add(this.pbIcon128px);
            this.pIcon128px.Location = new System.Drawing.Point(12, 12);
            this.pIcon128px.Name = "pIcon128px";
            this.pIcon128px.Size = new System.Drawing.Size(134, 134);
            this.pIcon128px.TabIndex = 4;
            // 
            // pIcon64px
            // 
            this.pIcon64px.AutoSize = true;
            this.pIcon64px.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pIcon64px.Controls.Add(this.pbIcon64px);
            this.pIcon64px.Location = new System.Drawing.Point(12, 152);
            this.pIcon64px.Name = "pIcon64px";
            this.pIcon64px.Size = new System.Drawing.Size(70, 70);
            this.pIcon64px.TabIndex = 5;
            // 
            // pIcon48px
            // 
            this.pIcon48px.AutoSize = true;
            this.pIcon48px.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pIcon48px.Controls.Add(this.pbIcon48px);
            this.pIcon48px.Location = new System.Drawing.Point(12, 228);
            this.pIcon48px.Name = "pIcon48px";
            this.pIcon48px.Size = new System.Drawing.Size(54, 54);
            this.pIcon48px.TabIndex = 5;
            // 
            // pIcon32px
            // 
            this.pIcon32px.AutoSize = true;
            this.pIcon32px.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pIcon32px.Controls.Add(this.pbIcon32px);
            this.pIcon32px.Location = new System.Drawing.Point(12, 288);
            this.pIcon32px.Name = "pIcon32px";
            this.pIcon32px.Size = new System.Drawing.Size(38, 38);
            this.pIcon32px.TabIndex = 5;
            // 
            // pIcon24px
            // 
            this.pIcon24px.AutoSize = true;
            this.pIcon24px.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pIcon24px.Controls.Add(this.pbIcon24px);
            this.pIcon24px.Location = new System.Drawing.Point(12, 332);
            this.pIcon24px.Name = "pIcon24px";
            this.pIcon24px.Size = new System.Drawing.Size(30, 30);
            this.pIcon24px.TabIndex = 5;
            // 
            // pIcon16px
            // 
            this.pIcon16px.AutoSize = true;
            this.pIcon16px.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pIcon16px.Controls.Add(this.pbIcon16px);
            this.pIcon16px.Location = new System.Drawing.Point(12, 368);
            this.pIcon16px.Name = "pIcon16px";
            this.pIcon16px.Size = new System.Drawing.Size(22, 22);
            this.pIcon16px.TabIndex = 5;
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(174, 12);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(115, 60);
            this.btnHelp.TabIndex = 2;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 410);
            this.Controls.Add(this.pIcon16px);
            this.Controls.Add(this.pIcon24px);
            this.Controls.Add(this.pIcon32px);
            this.Controls.Add(this.pIcon48px);
            this.Controls.Add(this.pIcon64px);
            this.Controls.Add(this.pIcon128px);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Simple Icon Builder";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon128px)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon64px)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon24px)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon32px)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon48px)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon16px)).EndInit();
            this.pIcon128px.ResumeLayout(false);
            this.pIcon64px.ResumeLayout(false);
            this.pIcon48px.ResumeLayout(false);
            this.pIcon32px.ResumeLayout(false);
            this.pIcon24px.ResumeLayout(false);
            this.pIcon16px.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbIcon16px;
        private System.Windows.Forms.PictureBox pbIcon48px;
        private System.Windows.Forms.PictureBox pbIcon64px;
        private System.Windows.Forms.PictureBox pbIcon32px;
        private System.Windows.Forms.PictureBox pbIcon24px;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.SaveFileDialog sfdIcon;
        private System.Windows.Forms.PictureBox pbIcon128px;
        private System.Windows.Forms.Panel pIcon128px;
        private System.Windows.Forms.Panel pIcon64px;
        private System.Windows.Forms.Panel pIcon48px;
        private System.Windows.Forms.Panel pIcon32px;
        private System.Windows.Forms.Panel pIcon24px;
        private System.Windows.Forms.Panel pIcon16px;
        private System.Windows.Forms.Button btnHelp;
    }
}

