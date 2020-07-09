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
    public partial class AddEditNote : Form
    {
        private Note _tempNote;
        public Note TempNote { get; set; }

        private Project _tempProject;


        public Project TempProject
        {
            get
            {
                return  _tempProject;
            }
            set
            {
                _tempProject = value;
            }
        }

        public AddEditNote()
        {
            InitializeComponent();
            foreach (var category in Enum.GetValues(typeof(NoteCategory)))
            {
                NoteCategoryEditComboBox.Items.Add(category);
            }
            _tempNote = new Note(DateTime.Now, DateTime.Now, "No Name", "", NoteCategory.Other);
            NoteTitleTextbox.Text = _tempNote.Name;
        }

        private void ButtonEditNoteOK_Click(object sender, EventArgs e)
        {
            Note newNote = new Note(DateTime.Now, DateTime.Now, NoteTitleTextbox.Text,NoteEditRichTextBox.Text,
                (NoteCategory)NoteCategoryEditComboBox.SelectedItem);
            _tempProject.Notes.Add(newNote);
            this.Close();
        }

        private void ButtonEditNoteCancel_Click(object sender, EventArgs e)
        {
            
        }
    }
}
