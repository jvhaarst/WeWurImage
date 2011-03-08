namespace wewurimage {
    partial class WeWurForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeWurForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonFetch = new System.Windows.Forms.Button();
            this.labelAccount = new System.Windows.Forms.Label();
            this.textBoxAccount = new System.Windows.Forms.TextBox();
            this.pictureBoxAccountImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAccountImage)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.buttonFetch);
            this.splitContainer1.Panel1.Controls.Add(this.labelAccount);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxAccount);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBoxAccountImage);
            this.splitContainer1.Size = new System.Drawing.Size(242, 316);
            this.splitContainer1.SplitterDistance = 79;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // buttonFetch
            // 
            this.buttonFetch.Location = new System.Drawing.Point(143, 30);
            this.buttonFetch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonFetch.Name = "buttonFetch";
            this.buttonFetch.Size = new System.Drawing.Size(88, 27);
            this.buttonFetch.TabIndex = 2;
            this.buttonFetch.Text = "Fetch";
            this.buttonFetch.UseVisualStyleBackColor = true;
            this.buttonFetch.Click += new System.EventHandler(this.buttonFetch_Click);
            // 
            // labelAccount
            // 
            this.labelAccount.AutoSize = true;
            this.labelAccount.Location = new System.Drawing.Point(15, 15);
            this.labelAccount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAccount.Name = "labelAccount";
            this.labelAccount.Size = new System.Drawing.Size(50, 15);
            this.labelAccount.TabIndex = 0;
            this.labelAccount.Text = "Account";
            // 
            // textBoxAccount
            // 
            this.textBoxAccount.AcceptsReturn = true;
            this.textBoxAccount.Location = new System.Drawing.Point(18, 33);
            this.textBoxAccount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxAccount.Name = "textBoxAccount";
            this.textBoxAccount.Size = new System.Drawing.Size(116, 21);
            this.textBoxAccount.TabIndex = 1;
            this.textBoxAccount.Text = "haars001";
            // 
            // pictureBoxAccountImage
            // 
            this.pictureBoxAccountImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxAccountImage.Image = global::wewurimage.Properties.Resources.quickmark;
            this.pictureBoxAccountImage.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxAccountImage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBoxAccountImage.Name = "pictureBoxAccountImage";
            this.pictureBoxAccountImage.Size = new System.Drawing.Size(242, 232);
            this.pictureBoxAccountImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAccountImage.TabIndex = 0;
            this.pictureBoxAccountImage.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 316);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(250, 350);
            this.MinimumSize = new System.Drawing.Size(250, 350);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WeWur Image";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAccountImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button buttonFetch;
        private System.Windows.Forms.Label labelAccount;
        private System.Windows.Forms.TextBox textBoxAccount;
        private System.Windows.Forms.PictureBox pictureBoxAccountImage;
    }
}

