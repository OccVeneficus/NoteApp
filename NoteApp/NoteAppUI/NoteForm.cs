﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteApp;

namespace NoteAppUI
{
    public partial class NoteForm : Form
    {

        /// <summary>
        /// Заметка для редактирования/добавления
        /// </summary>
        public Note Note { get; set; }

        public NoteForm()
        {
            InitializeComponent();
            //TODO: AddRange?
            var enums = Enum.GetValues(typeof(NoteCategory));
            foreach (var category in Enum.GetValues(typeof(NoteCategory)))
            {
                NoteCategoryEditComboBox.Items.Add(category);
            }
        }

        private void ButtonEditNoteOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void ButtonEditNoteCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void NoteEditRichTextBox_TextChanged(object sender, EventArgs e)
        {
            Note.Text = NoteEditRichTextBox.Text;
        }

        private void AddEditNote_Shown(object sender, EventArgs e)
        {
            NoteEditRichTextBox.Text = Note.Text;
            NoteCategoryEditComboBox.SelectedItem = Note.Category;
            NoteTitleTextbox.Text = Note.Name;
            NoteCreatedEditDateTime.Value = Note.CreatedDate;
            NoteModifiedEditDateTime.Value = Note.ModifidedDate;
        }

        private void NoteCategoryEditComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Note.Category = (NoteCategory)NoteCategoryEditComboBox.SelectedItem;
        }

        private void NoteTitleTextbox_Validating(object sender, CancelEventArgs e)
        {
            if (NoteTitleTextbox.Text.Length > 50)
            {
                e.Cancel = true;
                NoteTitleTextbox.Select(0,NoteTitleTextbox.Text.Length);
            }
        }

        private void NoteTitleTextbox_Validated(object sender, EventArgs e)
        {
            Note.Name = NoteTitleTextbox.Text;
        }

        private void NoteTitleTextbox_TextChanged(object sender, EventArgs e)
        {
            if (NoteTitleTextbox.Text.Length > 50)
            {
                NoteTitleTextbox.BackColor = Color.LightSalmon;
            }
            else
            {
                NoteTitleTextbox.BackColor = Color.White;
                Note.Name = NoteTitleTextbox.Text;
            }
        }
    }
}
