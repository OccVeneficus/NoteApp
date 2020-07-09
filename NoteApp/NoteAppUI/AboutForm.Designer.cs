namespace NoteAppUI
{
    partial class About
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
            this.NoteAppLabel = new System.Windows.Forms.Label();
            this.NoteAppVersionLabel = new System.Windows.Forms.Label();
            this.NoteAppAuthorLabel = new System.Windows.Forms.Label();
            this.NoteAppEmailLabel = new System.Windows.Forms.Label();
            this.NoteAppEmailLinkLabel = new System.Windows.Forms.LinkLabel();
            this.NoteAppGitHubLabel = new System.Windows.Forms.Label();
            this.NoteAppGitHubLinkLabel = new System.Windows.Forms.LinkLabel();
            this.NoteAppCopyrightLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NoteAppLabel
            // 
            this.NoteAppLabel.AutoSize = true;
            this.NoteAppLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NoteAppLabel.Location = new System.Drawing.Point(19, 22);
            this.NoteAppLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NoteAppLabel.Name = "NoteAppLabel";
            this.NoteAppLabel.Size = new System.Drawing.Size(92, 24);
            this.NoteAppLabel.TabIndex = 0;
            this.NoteAppLabel.Text = "NoteApp";
            // 
            // NoteAppVersionLabel
            // 
            this.NoteAppVersionLabel.AutoSize = true;
            this.NoteAppVersionLabel.Location = new System.Drawing.Point(20, 53);
            this.NoteAppVersionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NoteAppVersionLabel.Name = "NoteAppVersionLabel";
            this.NoteAppVersionLabel.Size = new System.Drawing.Size(43, 13);
            this.NoteAppVersionLabel.TabIndex = 1;
            this.NoteAppVersionLabel.Text = "v. 1.0.0";
            // 
            // NoteAppAuthorLabel
            // 
            this.NoteAppAuthorLabel.AutoSize = true;
            this.NoteAppAuthorLabel.Location = new System.Drawing.Point(20, 97);
            this.NoteAppAuthorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NoteAppAuthorLabel.Name = "NoteAppAuthorLabel";
            this.NoteAppAuthorLabel.Size = new System.Drawing.Size(143, 13);
            this.NoteAppAuthorLabel.TabIndex = 2;
            this.NoteAppAuthorLabel.Text = "Author: Nikolai Naberezhnev";
            // 
            // NoteAppEmailLabel
            // 
            this.NoteAppEmailLabel.AutoSize = true;
            this.NoteAppEmailLabel.Location = new System.Drawing.Point(20, 131);
            this.NoteAppEmailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NoteAppEmailLabel.Name = "NoteAppEmailLabel";
            this.NoteAppEmailLabel.Size = new System.Drawing.Size(100, 13);
            this.NoteAppEmailLabel.TabIndex = 3;
            this.NoteAppEmailLabel.Text = "e-mail for feedback:";
            // 
            // NoteAppEmailLinkLabel
            // 
            this.NoteAppEmailLinkLabel.AutoSize = true;
            this.NoteAppEmailLinkLabel.Location = new System.Drawing.Point(117, 131);
            this.NoteAppEmailLinkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NoteAppEmailLinkLabel.Name = "NoteAppEmailLinkLabel";
            this.NoteAppEmailLinkLabel.Size = new System.Drawing.Size(102, 13);
            this.NoteAppEmailLinkLabel.TabIndex = 4;
            this.NoteAppEmailLinkLabel.TabStop = true;
            this.NoteAppEmailLinkLabel.Text = "supovik@gmail.com";
            // 
            // NoteAppGitHubLabel
            // 
            this.NoteAppGitHubLabel.AutoSize = true;
            this.NoteAppGitHubLabel.Location = new System.Drawing.Point(20, 154);
            this.NoteAppGitHubLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NoteAppGitHubLabel.Name = "NoteAppGitHubLabel";
            this.NoteAppGitHubLabel.Size = new System.Drawing.Size(43, 13);
            this.NoteAppGitHubLabel.TabIndex = 5;
            this.NoteAppGitHubLabel.Text = "GitHub:";
            // 
            // NoteAppGitHubLinkLabel
            // 
            this.NoteAppGitHubLinkLabel.AutoSize = true;
            this.NoteAppGitHubLinkLabel.Location = new System.Drawing.Point(58, 154);
            this.NoteAppGitHubLinkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NoteAppGitHubLinkLabel.Name = "NoteAppGitHubLinkLabel";
            this.NoteAppGitHubLinkLabel.Size = new System.Drawing.Size(121, 13);
            this.NoteAppGitHubLinkLabel.TabIndex = 6;
            this.NoteAppGitHubLinkLabel.TabStop = true;
            this.NoteAppGitHubLinkLabel.Text = "OccVeneficus/NoteApp";
            // 
            // NoteAppCopyrightLabel
            // 
            this.NoteAppCopyrightLabel.AutoSize = true;
            this.NoteAppCopyrightLabel.Location = new System.Drawing.Point(9, 347);
            this.NoteAppCopyrightLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NoteAppCopyrightLabel.Name = "NoteAppCopyrightLabel";
            this.NoteAppCopyrightLabel.Size = new System.Drawing.Size(142, 13);
            this.NoteAppCopyrightLabel.TabIndex = 7;
            this.NoteAppCopyrightLabel.Text = "2020 Nikolai Naberezhnev©";
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 375);
            this.Controls.Add(this.NoteAppCopyrightLabel);
            this.Controls.Add(this.NoteAppGitHubLinkLabel);
            this.Controls.Add(this.NoteAppGitHubLabel);
            this.Controls.Add(this.NoteAppEmailLinkLabel);
            this.Controls.Add(this.NoteAppEmailLabel);
            this.Controls.Add(this.NoteAppAuthorLabel);
            this.Controls.Add(this.NoteAppVersionLabel);
            this.Controls.Add(this.NoteAppLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(454, 414);
            this.MinimumSize = new System.Drawing.Size(454, 414);
            this.Name = "About";
            this.ShowIcon = false;
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NoteAppLabel;
        private System.Windows.Forms.Label NoteAppVersionLabel;
        private System.Windows.Forms.Label NoteAppAuthorLabel;
        private System.Windows.Forms.Label NoteAppEmailLabel;
        private System.Windows.Forms.LinkLabel NoteAppEmailLinkLabel;
        private System.Windows.Forms.Label NoteAppGitHubLabel;
        private System.Windows.Forms.LinkLabel NoteAppGitHubLinkLabel;
        private System.Windows.Forms.Label NoteAppCopyrightLabel;
    }
}