using System;
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
        public Note TempNote { set; get; }

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
            TempNote.Text = NoteEditRichTextBox.Text;
        }

        private void AddEditNote_Shown(object sender, EventArgs e)
        {
            NoteEditRichTextBox.Text = TempNote.Text;
            NoteCategoryEditComboBox.SelectedItem = TempNote.Category;
            NoteTitleTextbox.Text = TempNote.Name;
            NoteCreatedEditDateTime.Value = TempNote.CreatedDate;
            NoteModifiedEditDateTime.Value = TempNote.ModifidedDate;
        }

        private void NoteCategoryEditComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            TempNote.Category = (NoteCategory)NoteCategoryEditComboBox.SelectedItem;
        }

        private void NoteTitleTextbox_Validating(object sender, CancelEventArgs e)
        {
            if (NoteTitleTextbox.Text.Length > 50)
            {
              //  NoteTitleTextbox.BackColor = Color.LightSalmon;
                e.Cancel = true;
                NoteTitleTextbox.Select(0,NoteTitleTextbox.Text.Length);
            }
        }

        private void NoteTitleTextbox_Validated(object sender, EventArgs e)
        {
            TempNote.Name = NoteTitleTextbox.Text;
           // NoteTitleTextbox.BackColor = Color.White;
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
                TempNote.Name = NoteTitleTextbox.Text;
            }
        }
    }
}
