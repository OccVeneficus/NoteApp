namespace NoteAppUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.imageList3 = new System.Windows.Forms.ImageList(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ButtonRemoveNote = new System.Windows.Forms.Button();
            this.ButtonEditNote = new System.Windows.Forms.Button();
            this.ButtonAddNote = new System.Windows.Forms.Button();
            this.NoteNamesListBox = new System.Windows.Forms.ListBox();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.ShowNoteCategoryLabel = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.ModifiedNoteLabel = new System.Windows.Forms.Label();
            this.ModifiedDateTime = new System.Windows.Forms.DateTimePicker();
            this.CreationDateTime = new System.Windows.Forms.DateTimePicker();
            this.CreatedNoteLabel = new System.Windows.Forms.Label();
            this.NoteCategory = new System.Windows.Forms.Label();
            this.CategoryNoteLabel = new System.Windows.Forms.Label();
            this.NoteNameLabel = new System.Windows.Forms.Label();
            this.NoteTextbox = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1.SuspendLayout();
            this.MainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.MainMenuStrip.Size = new System.Drawing.Size(948, 24);
            this.MainMenuStrip.TabIndex = 1;
            this.MainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editNoteToolStripMenuItem,
            this.deleteNoteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.addToolStripMenuItem.Text = "Add Note";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // editNoteToolStripMenuItem
            // 
            this.editNoteToolStripMenuItem.Name = "editNoteToolStripMenuItem";
            this.editNoteToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.editNoteToolStripMenuItem.Text = "Edit Note";
            this.editNoteToolStripMenuItem.Click += new System.EventHandler(this.editNoteToolStripMenuItem_Click);
            // 
            // deleteNoteToolStripMenuItem
            // 
            this.deleteNoteToolStripMenuItem.Name = "deleteNoteToolStripMenuItem";
            this.deleteNoteToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.deleteNoteToolStripMenuItem.Text = "Delete Note";
            this.deleteNoteToolStripMenuItem.Click += new System.EventHandler(this.deleteNoteToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Icons8-Windows-8-Files-Add-File.ico");
            this.imageList1.Images.SetKeyName(1, "Icons8-Windows-8-Files-Add-File.ico");
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "Icons8-Windows-8-Files-Edit-File.ico");
            this.imageList2.Images.SetKeyName(1, "Icons8-Windows-8-Files-Edit-File.ico");
            // 
            // imageList3
            // 
            this.imageList3.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList3.ImageStream")));
            this.imageList3.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList3.Images.SetKeyName(0, "Icons8-Windows-8-Files-Delete-File.ico");
            this.imageList3.Images.SetKeyName(1, "Icons8-Windows-8-Files-Delete-File.ico");
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ButtonRemoveNote);
            this.splitContainer1.Panel1.Controls.Add(this.ButtonEditNote);
            this.splitContainer1.Panel1.Controls.Add(this.ButtonAddNote);
            this.splitContainer1.Panel1.Controls.Add(this.NoteNamesListBox);
            this.splitContainer1.Panel1.Controls.Add(this.CategoryComboBox);
            this.splitContainer1.Panel1.Controls.Add(this.ShowNoteCategoryLabel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(948, 529);
            this.splitContainer1.SplitterDistance = 251;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // ButtonRemoveNote
            // 
            this.ButtonRemoveNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonRemoveNote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonRemoveNote.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.ButtonRemoveNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRemoveNote.ImageIndex = 0;
            this.ButtonRemoveNote.ImageList = this.imageList3;
            this.ButtonRemoveNote.Location = new System.Drawing.Point(55, 498);
            this.ButtonRemoveNote.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonRemoveNote.Name = "ButtonRemoveNote";
            this.ButtonRemoveNote.Size = new System.Drawing.Size(19, 20);
            this.ButtonRemoveNote.TabIndex = 3;
            this.ButtonRemoveNote.UseVisualStyleBackColor = true;
            this.ButtonRemoveNote.Click += new System.EventHandler(this.deleteNoteToolStripMenuItem_Click);
            // 
            // ButtonEditNote
            // 
            this.ButtonEditNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonEditNote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonEditNote.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.ButtonEditNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonEditNote.ImageIndex = 0;
            this.ButtonEditNote.ImageList = this.imageList2;
            this.ButtonEditNote.Location = new System.Drawing.Point(32, 498);
            this.ButtonEditNote.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonEditNote.Name = "ButtonEditNote";
            this.ButtonEditNote.Size = new System.Drawing.Size(19, 20);
            this.ButtonEditNote.TabIndex = 2;
            this.ButtonEditNote.UseVisualStyleBackColor = true;
            this.ButtonEditNote.Click += new System.EventHandler(this.editNoteToolStripMenuItem_Click);
            // 
            // ButtonAddNote
            // 
            this.ButtonAddNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonAddNote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAddNote.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.ButtonAddNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddNote.ImageIndex = 0;
            this.ButtonAddNote.ImageList = this.imageList1;
            this.ButtonAddNote.Location = new System.Drawing.Point(9, 498);
            this.ButtonAddNote.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonAddNote.Name = "ButtonAddNote";
            this.ButtonAddNote.Size = new System.Drawing.Size(19, 20);
            this.ButtonAddNote.TabIndex = 1;
            this.ButtonAddNote.UseVisualStyleBackColor = true;
            this.ButtonAddNote.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // NoteNamesListBox
            // 
            this.NoteNamesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.NoteNamesListBox.FormattingEnabled = true;
            this.NoteNamesListBox.Location = new System.Drawing.Point(4, 33);
            this.NoteNamesListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NoteNamesListBox.Name = "NoteNamesListBox";
            this.NoteNamesListBox.Size = new System.Drawing.Size(242, 420);
            this.NoteNamesListBox.TabIndex = 0;
            this.NoteNamesListBox.SelectedIndexChanged += new System.EventHandler(this.NoteNamesListBox_SelectedIndexChanged);
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(86, 6);
            this.CategoryComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(160, 21);
            this.CategoryComboBox.TabIndex = 0;
            // 
            // ShowNoteCategoryLabel
            // 
            this.ShowNoteCategoryLabel.AutoSize = true;
            this.ShowNoteCategoryLabel.Location = new System.Drawing.Point(2, 9);
            this.ShowNoteCategoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ShowNoteCategoryLabel.Name = "ShowNoteCategoryLabel";
            this.ShowNoteCategoryLabel.Size = new System.Drawing.Size(82, 13);
            this.ShowNoteCategoryLabel.TabIndex = 0;
            this.ShowNoteCategoryLabel.Text = "Show Category:";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.ModifiedNoteLabel);
            this.splitContainer2.Panel1.Controls.Add(this.ModifiedDateTime);
            this.splitContainer2.Panel1.Controls.Add(this.CreationDateTime);
            this.splitContainer2.Panel1.Controls.Add(this.CreatedNoteLabel);
            this.splitContainer2.Panel1.Controls.Add(this.NoteCategory);
            this.splitContainer2.Panel1.Controls.Add(this.CategoryNoteLabel);
            this.splitContainer2.Panel1.Controls.Add(this.NoteNameLabel);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.NoteTextbox);
            this.splitContainer2.Size = new System.Drawing.Size(694, 529);
            this.splitContainer2.SplitterDistance = 111;
            this.splitContainer2.SplitterWidth = 1;
            this.splitContainer2.TabIndex = 0;
            // 
            // ModifiedNoteLabel
            // 
            this.ModifiedNoteLabel.AutoSize = true;
            this.ModifiedNoteLabel.Location = new System.Drawing.Point(228, 76);
            this.ModifiedNoteLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ModifiedNoteLabel.Name = "ModifiedNoteLabel";
            this.ModifiedNoteLabel.Size = new System.Drawing.Size(50, 13);
            this.ModifiedNoteLabel.TabIndex = 6;
            this.ModifiedNoteLabel.Text = "Modified:";
            // 
            // ModifiedDateTime
            // 
            this.ModifiedDateTime.Enabled = false;
            this.ModifiedDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.ModifiedDateTime.Location = new System.Drawing.Point(281, 76);
            this.ModifiedDateTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ModifiedDateTime.Name = "ModifiedDateTime";
            this.ModifiedDateTime.Size = new System.Drawing.Size(82, 20);
            this.ModifiedDateTime.TabIndex = 5;
            // 
            // CreationDateTime
            // 
            this.CreationDateTime.Enabled = false;
            this.CreationDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.CreationDateTime.Location = new System.Drawing.Point(65, 76);
            this.CreationDateTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CreationDateTime.Name = "CreationDateTime";
            this.CreationDateTime.Size = new System.Drawing.Size(81, 20);
            this.CreationDateTime.TabIndex = 4;
            // 
            // CreatedNoteLabel
            // 
            this.CreatedNoteLabel.AutoSize = true;
            this.CreatedNoteLabel.Location = new System.Drawing.Point(12, 76);
            this.CreatedNoteLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CreatedNoteLabel.Name = "CreatedNoteLabel";
            this.CreatedNoteLabel.Size = new System.Drawing.Size(47, 13);
            this.CreatedNoteLabel.TabIndex = 3;
            this.CreatedNoteLabel.Text = "Created:";
            // 
            // NoteCategory
            // 
            this.NoteCategory.AutoSize = true;
            this.NoteCategory.Location = new System.Drawing.Point(63, 46);
            this.NoteCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NoteCategory.Name = "NoteCategory";
            this.NoteCategory.Size = new System.Drawing.Size(72, 13);
            this.NoteCategory.TabIndex = 2;
            this.NoteCategory.Text = "NoteCategory";
            // 
            // CategoryNoteLabel
            // 
            this.CategoryNoteLabel.AutoSize = true;
            this.CategoryNoteLabel.Location = new System.Drawing.Point(12, 46);
            this.CategoryNoteLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CategoryNoteLabel.Name = "CategoryNoteLabel";
            this.CategoryNoteLabel.Size = new System.Drawing.Size(52, 13);
            this.CategoryNoteLabel.TabIndex = 1;
            this.CategoryNoteLabel.Text = "Category:";
            // 
            // NoteNameLabel
            // 
            this.NoteNameLabel.AutoSize = true;
            this.NoteNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NoteNameLabel.Location = new System.Drawing.Point(21, 9);
            this.NoteNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NoteNameLabel.Name = "NoteNameLabel";
            this.NoteNameLabel.Size = new System.Drawing.Size(125, 26);
            this.NoteNameLabel.TabIndex = 0;
            this.NoteNameLabel.Text = "NoteName";
            // 
            // NoteTextbox
            // 
            this.NoteTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NoteTextbox.Enabled = false;
            this.NoteTextbox.Location = new System.Drawing.Point(0, 0);
            this.NoteTextbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NoteTextbox.Name = "NoteTextbox";
            this.NoteTextbox.Size = new System.Drawing.Size(694, 417);
            this.NoteTextbox.TabIndex = 0;
            this.NoteTextbox.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 553);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.MainMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "NoteApp";
            this.contextMenuStrip1.ResumeLayout(false);
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ImageList imageList3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox NoteNamesListBox;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.Label ShowNoteCategoryLabel;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label ModifiedNoteLabel;
        private System.Windows.Forms.DateTimePicker ModifiedDateTime;
        private System.Windows.Forms.DateTimePicker CreationDateTime;
        private System.Windows.Forms.Label CreatedNoteLabel;
        private System.Windows.Forms.Label NoteCategory;
        private System.Windows.Forms.Label CategoryNoteLabel;
        private System.Windows.Forms.Label NoteNameLabel;
        private System.Windows.Forms.RichTextBox NoteTextbox;
        private System.Windows.Forms.Button ButtonRemoveNote;
        private System.Windows.Forms.Button ButtonEditNote;
        private System.Windows.Forms.Button ButtonAddNote;
    }
}

