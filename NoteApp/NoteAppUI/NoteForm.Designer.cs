namespace NoteAppUI
{
    partial class NoteForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.NoteTitleTextbox = new System.Windows.Forms.TextBox();
            this.NoteTitleLabel = new System.Windows.Forms.Label();
            this.NoteCategoryEditLabel = new System.Windows.Forms.Label();
            this.NoteModifiedEditDateTime = new System.Windows.Forms.DateTimePicker();
            this.NoteCreatedDateEditLabel = new System.Windows.Forms.Label();
            this.NoteCreatedEditDateTime = new System.Windows.Forms.DateTimePicker();
            this.NoteModifiedDateEditLabel = new System.Windows.Forms.Label();
            this.NoteCategoryEditComboBox = new System.Windows.Forms.ComboBox();
            this.ButtonEditNoteCancel = new System.Windows.Forms.Button();
            this.ButtonEditNoteOK = new System.Windows.Forms.Button();
            this.NoteEditRichTextBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(20);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.NoteTitleTextbox);
            this.splitContainer1.Panel1.Controls.Add(this.NoteTitleLabel);
            this.splitContainer1.Panel1.Controls.Add(this.NoteCategoryEditLabel);
            this.splitContainer1.Panel1.Controls.Add(this.NoteModifiedEditDateTime);
            this.splitContainer1.Panel1.Controls.Add(this.NoteCreatedDateEditLabel);
            this.splitContainer1.Panel1.Controls.Add(this.NoteCreatedEditDateTime);
            this.splitContainer1.Panel1.Controls.Add(this.NoteModifiedDateEditLabel);
            this.splitContainer1.Panel1.Controls.Add(this.NoteCategoryEditComboBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ButtonEditNoteCancel);
            this.splitContainer1.Panel2.Controls.Add(this.ButtonEditNoteOK);
            this.splitContainer1.Panel2.Controls.Add(this.NoteEditRichTextBox);
            this.splitContainer1.Size = new System.Drawing.Size(600, 366);
            this.splitContainer1.SplitterDistance = 88;
            this.splitContainer1.TabIndex = 0;
            // 
            // NoteTitleTextbox
            // 
            this.NoteTitleTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NoteTitleTextbox.Location = new System.Drawing.Point(70, 10);
            this.NoteTitleTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.NoteTitleTextbox.Name = "NoteTitleTextbox";
            this.NoteTitleTextbox.Size = new System.Drawing.Size(519, 20);
            this.NoteTitleTextbox.TabIndex = 15;
            this.NoteTitleTextbox.TextChanged += new System.EventHandler(this.NoteTitleTextbox_TextChanged);
            this.NoteTitleTextbox.Validating += new System.ComponentModel.CancelEventHandler(this.NoteTitleTextbox_Validating);
            this.NoteTitleTextbox.Validated += new System.EventHandler(this.NoteTitleTextbox_Validated);
            // 
            // NoteTitleLabel
            // 
            this.NoteTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NoteTitleLabel.AutoSize = true;
            this.NoteTitleLabel.Location = new System.Drawing.Point(14, 13);
            this.NoteTitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NoteTitleLabel.Name = "NoteTitleLabel";
            this.NoteTitleLabel.Size = new System.Drawing.Size(30, 13);
            this.NoteTitleLabel.TabIndex = 11;
            this.NoteTitleLabel.Text = "Title:";
            // 
            // NoteCategoryEditLabel
            // 
            this.NoteCategoryEditLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NoteCategoryEditLabel.AutoSize = true;
            this.NoteCategoryEditLabel.Location = new System.Drawing.Point(14, 38);
            this.NoteCategoryEditLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NoteCategoryEditLabel.Name = "NoteCategoryEditLabel";
            this.NoteCategoryEditLabel.Size = new System.Drawing.Size(52, 13);
            this.NoteCategoryEditLabel.TabIndex = 12;
            this.NoteCategoryEditLabel.Text = "Category:";
            // 
            // NoteModifiedEditDateTime
            // 
            this.NoteModifiedEditDateTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NoteModifiedEditDateTime.Enabled = false;
            this.NoteModifiedEditDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.NoteModifiedEditDateTime.Location = new System.Drawing.Point(241, 60);
            this.NoteModifiedEditDateTime.Margin = new System.Windows.Forms.Padding(2);
            this.NoteModifiedEditDateTime.Name = "NoteModifiedEditDateTime";
            this.NoteModifiedEditDateTime.Size = new System.Drawing.Size(91, 20);
            this.NoteModifiedEditDateTime.TabIndex = 18;
            // 
            // NoteCreatedDateEditLabel
            // 
            this.NoteCreatedDateEditLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NoteCreatedDateEditLabel.AutoSize = true;
            this.NoteCreatedDateEditLabel.Location = new System.Drawing.Point(14, 64);
            this.NoteCreatedDateEditLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NoteCreatedDateEditLabel.Name = "NoteCreatedDateEditLabel";
            this.NoteCreatedDateEditLabel.Size = new System.Drawing.Size(47, 13);
            this.NoteCreatedDateEditLabel.TabIndex = 13;
            this.NoteCreatedDateEditLabel.Text = "Created:";
            // 
            // NoteCreatedEditDateTime
            // 
            this.NoteCreatedEditDateTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NoteCreatedEditDateTime.Enabled = false;
            this.NoteCreatedEditDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.NoteCreatedEditDateTime.Location = new System.Drawing.Point(70, 60);
            this.NoteCreatedEditDateTime.Margin = new System.Windows.Forms.Padding(2);
            this.NoteCreatedEditDateTime.Name = "NoteCreatedEditDateTime";
            this.NoteCreatedEditDateTime.Size = new System.Drawing.Size(91, 20);
            this.NoteCreatedEditDateTime.TabIndex = 17;
            // 
            // NoteModifiedDateEditLabel
            // 
            this.NoteModifiedDateEditLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NoteModifiedDateEditLabel.AutoSize = true;
            this.NoteModifiedDateEditLabel.Location = new System.Drawing.Point(187, 64);
            this.NoteModifiedDateEditLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NoteModifiedDateEditLabel.Name = "NoteModifiedDateEditLabel";
            this.NoteModifiedDateEditLabel.Size = new System.Drawing.Size(50, 13);
            this.NoteModifiedDateEditLabel.TabIndex = 14;
            this.NoteModifiedDateEditLabel.Text = "Modified:";
            // 
            // NoteCategoryEditComboBox
            // 
            this.NoteCategoryEditComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NoteCategoryEditComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NoteCategoryEditComboBox.FormattingEnabled = true;
            this.NoteCategoryEditComboBox.Location = new System.Drawing.Point(70, 35);
            this.NoteCategoryEditComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.NoteCategoryEditComboBox.Name = "NoteCategoryEditComboBox";
            this.NoteCategoryEditComboBox.Size = new System.Drawing.Size(137, 21);
            this.NoteCategoryEditComboBox.TabIndex = 16;
            this.NoteCategoryEditComboBox.SelectedIndexChanged += new System.EventHandler(this.NoteCategoryEditComboBox_SelectedIndexChanged);
            // 
            // ButtonEditNoteCancel
            // 
            this.ButtonEditNoteCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonEditNoteCancel.Location = new System.Drawing.Point(533, 246);
            this.ButtonEditNoteCancel.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonEditNoteCancel.Name = "ButtonEditNoteCancel";
            this.ButtonEditNoteCancel.Size = new System.Drawing.Size(56, 19);
            this.ButtonEditNoteCancel.TabIndex = 21;
            this.ButtonEditNoteCancel.Text = "Cancel";
            this.ButtonEditNoteCancel.UseVisualStyleBackColor = true;
            this.ButtonEditNoteCancel.Click += new System.EventHandler(this.ButtonEditNoteCancel_Click);
            // 
            // ButtonEditNoteOK
            // 
            this.ButtonEditNoteOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonEditNoteOK.Location = new System.Drawing.Point(473, 246);
            this.ButtonEditNoteOK.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonEditNoteOK.Name = "ButtonEditNoteOK";
            this.ButtonEditNoteOK.Size = new System.Drawing.Size(56, 19);
            this.ButtonEditNoteOK.TabIndex = 20;
            this.ButtonEditNoteOK.Text = "OK";
            this.ButtonEditNoteOK.UseVisualStyleBackColor = true;
            this.ButtonEditNoteOK.Click += new System.EventHandler(this.ButtonEditNoteOK_Click);
            // 
            // NoteEditRichTextBox
            // 
            this.NoteEditRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NoteEditRichTextBox.Location = new System.Drawing.Point(11, 2);
            this.NoteEditRichTextBox.Margin = new System.Windows.Forms.Padding(50);
            this.NoteEditRichTextBox.Name = "NoteEditRichTextBox";
            this.NoteEditRichTextBox.Size = new System.Drawing.Size(578, 240);
            this.NoteEditRichTextBox.TabIndex = 19;
            this.NoteEditRichTextBox.Text = "";
            this.NoteEditRichTextBox.TextChanged += new System.EventHandler(this.NoteEditRichTextBox_TextChanged);
            // 
            // NoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NoteForm";
            this.ShowIcon = false;
            this.Text = "Add/Edit Note";
            this.Shown += new System.EventHandler(this.AddEditNote_Shown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox NoteTitleTextbox;
        private System.Windows.Forms.Label NoteTitleLabel;
        private System.Windows.Forms.Label NoteCategoryEditLabel;
        private System.Windows.Forms.DateTimePicker NoteModifiedEditDateTime;
        private System.Windows.Forms.Label NoteCreatedDateEditLabel;
        private System.Windows.Forms.DateTimePicker NoteCreatedEditDateTime;
        private System.Windows.Forms.Label NoteModifiedDateEditLabel;
        private System.Windows.Forms.ComboBox NoteCategoryEditComboBox;
        private System.Windows.Forms.Button ButtonEditNoteCancel;
        private System.Windows.Forms.Button ButtonEditNoteOK;
        private System.Windows.Forms.RichTextBox NoteEditRichTextBox;
    }
}