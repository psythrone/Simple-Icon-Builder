namespace PNG_To_Ico
{
    partial class CropForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CropForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUp = new System.Windows.Forms.Button();
            this.p16px = new System.Windows.Forms.Panel();
            this.pb16px = new System.Windows.Forms.PictureBox();
            this.p24px = new System.Windows.Forms.Panel();
            this.pb24px = new System.Windows.Forms.PictureBox();
            this.p32px = new System.Windows.Forms.Panel();
            this.pb32px = new System.Windows.Forms.PictureBox();
            this.p48px = new System.Windows.Forms.Panel();
            this.pb48px = new System.Windows.Forms.PictureBox();
            this.p64px = new System.Windows.Forms.Panel();
            this.pb64px = new System.Windows.Forms.PictureBox();
            this.p128px = new System.Windows.Forms.Panel();
            this.pb128px = new System.Windows.Forms.PictureBox();
            this.pbDropped = new System.Windows.Forms.PictureBox();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.pButtons = new System.Windows.Forms.Panel();
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.p16px.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb16px)).BeginInit();
            this.p24px.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb24px)).BeginInit();
            this.p32px.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb32px)).BeginInit();
            this.p48px.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb48px)).BeginInit();
            this.p64px.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb64px)).BeginInit();
            this.p128px.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb128px)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDropped)).BeginInit();
            this.pButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnCancel);
            this.splitContainer1.Panel1.Controls.Add(this.btnHelp);
            this.splitContainer1.Panel1.Controls.Add(this.btnSave);
            this.splitContainer1.Panel1.Controls.Add(this.lblY);
            this.splitContainer1.Panel1.Controls.Add(this.lblX);
            this.splitContainer1.Panel1.Controls.Add(this.pButtons);
            this.splitContainer1.Panel1.Controls.Add(this.p16px);
            this.splitContainer1.Panel1.Controls.Add(this.p24px);
            this.splitContainer1.Panel1.Controls.Add(this.p32px);
            this.splitContainer1.Panel1.Controls.Add(this.p48px);
            this.splitContainer1.Panel1.Controls.Add(this.p64px);
            this.splitContainer1.Panel1.Controls.Add(this.p128px);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.AutoScrollMargin = new System.Drawing.Size(1, 1);
            this.splitContainer1.Panel2.Controls.Add(this.pbDropped);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Panel2MinSize = 138;
            this.splitContainer1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(784, 561);
            this.splitContainer1.SplitterDistance = 138;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(33, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(24, 24);
            this.panel1.TabIndex = 3;
            // 
            // btnUp
            // 
            this.btnUp.BackgroundImage = global::PNG_To_Ico.Properties.Resources.UArrow;
            this.btnUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnUp.Location = new System.Drawing.Point(33, 3);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(24, 24);
            this.btnUp.TabIndex = 2;
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // p16px
            // 
            this.p16px.Controls.Add(this.pb16px);
            this.p16px.Location = new System.Drawing.Point(3, 3);
            this.p16px.Name = "p16px";
            this.p16px.Size = new System.Drawing.Size(20, 20);
            this.p16px.TabIndex = 1;
            // 
            // pb16px
            // 
            this.pb16px.Location = new System.Drawing.Point(2, 2);
            this.pb16px.Margin = new System.Windows.Forms.Padding(2);
            this.pb16px.Name = "pb16px";
            this.pb16px.Size = new System.Drawing.Size(16, 16);
            this.pb16px.TabIndex = 0;
            this.pb16px.TabStop = false;
            this.pb16px.Click += new System.EventHandler(this.pb16px_Click);
            // 
            // p24px
            // 
            this.p24px.Controls.Add(this.pb24px);
            this.p24px.Location = new System.Drawing.Point(3, 29);
            this.p24px.Name = "p24px";
            this.p24px.Size = new System.Drawing.Size(28, 28);
            this.p24px.TabIndex = 1;
            // 
            // pb24px
            // 
            this.pb24px.Location = new System.Drawing.Point(2, 2);
            this.pb24px.Margin = new System.Windows.Forms.Padding(2);
            this.pb24px.Name = "pb24px";
            this.pb24px.Size = new System.Drawing.Size(24, 24);
            this.pb24px.TabIndex = 0;
            this.pb24px.TabStop = false;
            this.pb24px.Click += new System.EventHandler(this.pb24px_Click);
            // 
            // p32px
            // 
            this.p32px.Controls.Add(this.pb32px);
            this.p32px.Location = new System.Drawing.Point(3, 63);
            this.p32px.Name = "p32px";
            this.p32px.Size = new System.Drawing.Size(36, 36);
            this.p32px.TabIndex = 1;
            // 
            // pb32px
            // 
            this.pb32px.Location = new System.Drawing.Point(2, 2);
            this.pb32px.Margin = new System.Windows.Forms.Padding(2);
            this.pb32px.Name = "pb32px";
            this.pb32px.Size = new System.Drawing.Size(32, 32);
            this.pb32px.TabIndex = 0;
            this.pb32px.TabStop = false;
            this.pb32px.Click += new System.EventHandler(this.pb32px_Click);
            // 
            // p48px
            // 
            this.p48px.Controls.Add(this.pb48px);
            this.p48px.Location = new System.Drawing.Point(3, 105);
            this.p48px.Name = "p48px";
            this.p48px.Size = new System.Drawing.Size(52, 52);
            this.p48px.TabIndex = 1;
            // 
            // pb48px
            // 
            this.pb48px.Location = new System.Drawing.Point(2, 2);
            this.pb48px.Margin = new System.Windows.Forms.Padding(2);
            this.pb48px.Name = "pb48px";
            this.pb48px.Size = new System.Drawing.Size(48, 48);
            this.pb48px.TabIndex = 0;
            this.pb48px.TabStop = false;
            this.pb48px.Click += new System.EventHandler(this.pb48px_Click);
            // 
            // p64px
            // 
            this.p64px.Controls.Add(this.pb64px);
            this.p64px.Location = new System.Drawing.Point(3, 163);
            this.p64px.Name = "p64px";
            this.p64px.Size = new System.Drawing.Size(68, 68);
            this.p64px.TabIndex = 1;
            // 
            // pb64px
            // 
            this.pb64px.Location = new System.Drawing.Point(2, 2);
            this.pb64px.Margin = new System.Windows.Forms.Padding(2);
            this.pb64px.Name = "pb64px";
            this.pb64px.Size = new System.Drawing.Size(64, 64);
            this.pb64px.TabIndex = 0;
            this.pb64px.TabStop = false;
            this.pb64px.Click += new System.EventHandler(this.pb64px_Click);
            // 
            // p128px
            // 
            this.p128px.Controls.Add(this.pb128px);
            this.p128px.Location = new System.Drawing.Point(3, 237);
            this.p128px.Name = "p128px";
            this.p128px.Size = new System.Drawing.Size(132, 132);
            this.p128px.TabIndex = 0;
            // 
            // pb128px
            // 
            this.pb128px.Location = new System.Drawing.Point(2, 2);
            this.pb128px.Margin = new System.Windows.Forms.Padding(2);
            this.pb128px.Name = "pb128px";
            this.pb128px.Size = new System.Drawing.Size(128, 128);
            this.pb128px.TabIndex = 0;
            this.pb128px.TabStop = false;
            this.pb128px.Click += new System.EventHandler(this.pb128px_Click);
            // 
            // pbDropped
            // 
            this.pbDropped.Location = new System.Drawing.Point(3, 3);
            this.pbDropped.Name = "pbDropped";
            this.pbDropped.Size = new System.Drawing.Size(128, 128);
            this.pbDropped.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbDropped.TabIndex = 0;
            this.pbDropped.TabStop = false;
            this.pbDropped.Click += new System.EventHandler(this.pbDropped_Click);
            this.pbDropped.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbDropped_MouseMove);
            // 
            // btnDown
            // 
            this.btnDown.BackgroundImage = global::PNG_To_Ico.Properties.Resources.DArrow;
            this.btnDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDown.Location = new System.Drawing.Point(33, 63);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(24, 24);
            this.btnDown.TabIndex = 2;
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.BackgroundImage = global::PNG_To_Ico.Properties.Resources.LArrow;
            this.btnLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLeft.Location = new System.Drawing.Point(3, 33);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(24, 24);
            this.btnLeft.TabIndex = 2;
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.BackgroundImage = global::PNG_To_Ico.Properties.Resources.RArrow;
            this.btnRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRight.Location = new System.Drawing.Point(63, 33);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(24, 24);
            this.btnRight.TabIndex = 2;
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // pButtons
            // 
            this.pButtons.Controls.Add(this.panel1);
            this.pButtons.Controls.Add(this.btnUp);
            this.pButtons.Controls.Add(this.btnRight);
            this.pButtons.Controls.Add(this.btnLeft);
            this.pButtons.Controls.Add(this.btnDown);
            this.pButtons.Location = new System.Drawing.Point(45, 3);
            this.pButtons.Name = "pButtons";
            this.pButtons.Size = new System.Drawing.Size(90, 90);
            this.pButtons.TabIndex = 1;
            this.pButtons.Visible = false;
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(3, 372);
            this.lblX.Name = "lblX";
            this.lblX.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblX.Size = new System.Drawing.Size(35, 13);
            this.lblX.TabIndex = 2;
            this.lblX.Text = "label1";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(3, 414);
            this.lblY.Name = "lblY";
            this.lblY.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblY.Size = new System.Drawing.Size(35, 13);
            this.lblY.TabIndex = 2;
            this.lblY.Text = "label1";
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(3, 456);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(132, 30);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save Selected";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(3, 528);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(132, 30);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(3, 492);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(132, 30);
            this.btnHelp.TabIndex = 3;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // CropForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CropForm";
            this.Text = "CropForm";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.p16px.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb16px)).EndInit();
            this.p24px.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb24px)).EndInit();
            this.p32px.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb32px)).EndInit();
            this.p48px.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb48px)).EndInit();
            this.p64px.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb64px)).EndInit();
            this.p128px.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb128px)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDropped)).EndInit();
            this.pButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel p16px;
        private System.Windows.Forms.PictureBox pb16px;
        private System.Windows.Forms.Panel p24px;
        private System.Windows.Forms.PictureBox pb24px;
        private System.Windows.Forms.Panel p32px;
        private System.Windows.Forms.PictureBox pb32px;
        private System.Windows.Forms.Panel p48px;
        private System.Windows.Forms.PictureBox pb48px;
        private System.Windows.Forms.Panel p64px;
        private System.Windows.Forms.PictureBox pb64px;
        private System.Windows.Forms.Panel p128px;
        private System.Windows.Forms.PictureBox pb128px;
        private System.Windows.Forms.PictureBox pbDropped;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pButtons;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnSave;
    }
}