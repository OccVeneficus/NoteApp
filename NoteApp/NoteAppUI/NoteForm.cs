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
{ //TODO: имя файла не соответствует имени класса
    public partial class NoteForm : Form
    { //TODO: почему Temp? Temp - это имя для переменных внутри метода, а не для свойств и полей. //TODO: xml

        /// <summary>
        /// Заметка для редактирования/добавления
        /// </summary>
        public Note OpenNote { set; get; }

        public NoteForm()
        {
            InitializeComponent();
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
            this.Close();
        }

        private void NoteEditRichTextBox_TextChanged(object sender, EventArgs e)
        {
            OpenNote.Text = NoteEditRichTextBox.Text;
        }

        private void AddEditNote_Shown(object sender, EventArgs e)
        {
            NoteEditRichTextBox.Text = OpenNote.Text;
            NoteCategoryEditComboBox.SelectedItem = OpenNote.Category;
            NoteTitleTextbox.Text = OpenNote.Name;
            NoteCreatedEditDateTime.Value = OpenNote.CreatedDate;
            NoteModifiedEditDateTime.Value = OpenNote.ModifidedDate;
        }

        private void NoteCategoryEditComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            OpenNote.Category = (NoteCategory)NoteCategoryEditComboBox.SelectedItem;
        }

        private void NoteTitleTextbox_Validating(object sender, CancelEventArgs e)
        {
            if (NoteTitleTextbox.Text.Length > 50)
            { //TODO: закомментированный код на пул реквесты на отправляется - если он не нужен, удалить. Если нужен, то оставить комментарий с информацией для других разработчиков
                e.Cancel = true;
                NoteTitleTextbox.Select(0,NoteTitleTextbox.Text.Length);
            }
        }

        private void NoteTitleTextbox_Validated(object sender, EventArgs e)
        {
            OpenNote.Name = NoteTitleTextbox.Text;
            //TODO: см. выше
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
                OpenNote.Name = NoteTitleTextbox.Text;
            }
        }
    }
}