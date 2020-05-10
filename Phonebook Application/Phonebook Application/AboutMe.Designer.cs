namespace Phonebook_Application
{
    partial class AboutMe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.github_link = new System.Windows.Forms.PictureBox();
            this.linkedin_link = new System.Windows.Forms.PictureBox();
            this.instagram_link = new System.Windows.Forms.PictureBox();
            this.facebook_link = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.github_link)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkedin_link)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instagram_link)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facebook_link)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(129, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Developed By";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(93, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Muhammad Sameem";
            // 
            // github_link
            // 
            this.github_link.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.github_link.Image = global::Phonebook_Application.Properties.Resources.github;
            this.github_link.Location = new System.Drawing.Point(322, 138);
            this.github_link.Name = "github_link";
            this.github_link.Size = new System.Drawing.Size(71, 61);
            this.github_link.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.github_link.TabIndex = 1;
            this.github_link.TabStop = false;
            this.github_link.Click += new System.EventHandler(this.github_link_Click);
            // 
            // linkedin_link
            // 
            this.linkedin_link.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.linkedin_link.Image = global::Phonebook_Application.Properties.Resources.linkedin;
            this.linkedin_link.Location = new System.Drawing.Point(228, 138);
            this.linkedin_link.Name = "linkedin_link";
            this.linkedin_link.Size = new System.Drawing.Size(71, 61);
            this.linkedin_link.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.linkedin_link.TabIndex = 1;
            this.linkedin_link.TabStop = false;
            this.linkedin_link.Click += new System.EventHandler(this.linkedin_link_Click);
            // 
            // instagram_link
            // 
            this.instagram_link.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.instagram_link.Image = global::Phonebook_Application.Properties.Resources.instagram;
            this.instagram_link.Location = new System.Drawing.Point(133, 138);
            this.instagram_link.Name = "instagram_link";
            this.instagram_link.Size = new System.Drawing.Size(71, 61);
            this.instagram_link.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.instagram_link.TabIndex = 1;
            this.instagram_link.TabStop = false;
            this.instagram_link.Click += new System.EventHandler(this.instagram_link_Click);
            // 
            // facebook_link
            // 
            this.facebook_link.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.facebook_link.Image = global::Phonebook_Application.Properties.Resources.facebook;
            this.facebook_link.Location = new System.Drawing.Point(40, 138);
            this.facebook_link.Name = "facebook_link";
            this.facebook_link.Size = new System.Drawing.Size(71, 61);
            this.facebook_link.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.facebook_link.TabIndex = 1;
            this.facebook_link.TabStop = false;
            this.facebook_link.Click += new System.EventHandler(this.facebook_link_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Phonebook_Application.Properties.Resources.pk;
            this.pictureBox1.Location = new System.Drawing.Point(173, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // AboutMe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 244);
            this.Controls.Add(this.github_link);
            this.Controls.Add(this.linkedin_link);
            this.Controls.Add(this.instagram_link);
            this.Controls.Add(this.facebook_link);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutMe";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About Me";
            ((System.ComponentModel.ISupportInitialize)(this.github_link)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkedin_link)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instagram_link)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facebook_link)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox facebook_link;
        private System.Windows.Forms.PictureBox instagram_link;
        private System.Windows.Forms.PictureBox linkedin_link;
        private System.Windows.Forms.PictureBox github_link;
    }
}
