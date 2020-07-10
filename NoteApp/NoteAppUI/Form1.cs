using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteApp;

namespace NoteAppUI
{
    public partial class MainForm : Form
    {
        private Project _project;

        private Note _tempNote;

        public MainForm()
        {
            InitializeComponent();

            foreach (var category in Enum.GetValues(typeof(NoteCategory)))
            {
                CategoryComboBox.Items.Add(category);
            }
            CategoryComboBox.Items.Add("All");

            try
            {
                _project = ProjectManager.LoadFromFile(
                    Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\NoteApp\\NoteApp.notes");
            }
            catch (Exception)
            {
                _project = new Project();
            }

            foreach (var note in _project.Notes)
            {
                NoteNamesListBox.Items.Add(note.Name);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NoteForm addEditNote = new NoteForm();
            addEditNote.TempNote = new Note(DateTime.Now, DateTime.Now, "No name", "", NoteApp.NoteCategory.Other);
            addEditNote.ShowDialog();
            if (addEditNote.DialogResult == DialogResult.OK)
            {
                _project.Notes.Add(addEditNote.TempNote);
                NoteNamesListBox.Items.Add(addEditNote.TempNote.Name);
                ProjectManager.SaveToFile(_project, Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\NoteApp\\NoteApp.notes");
            }
        }

        private void editNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _tempNote = _project.Notes.Find(note => note.Name.Equals(NoteNamesListBox.SelectedItem.ToString()));
            NoteForm addEditNote = new NoteForm();
            addEditNote.TempNote = _tempNote;
            addEditNote.ShowDialog();
            if (addEditNote.DialogResult == DialogResult.OK)
            {
                _tempNote = addEditNote.TempNote;
                _tempNote.ModifidedDate = DateTime.Now;
                NoteNamesListBox.Items.Clear();
                foreach (var note in _project.Notes)
                {
                    NoteNamesListBox.Items.Add(note.Name);
                }
                ProjectManager.SaveToFile(_project, Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\NoteApp\\NoteApp.notes");
                NoteNamesListBox.SelectedItem = _tempNote.Name;
            }
        }

        private void deleteNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы точно хотите удалить " + NoteNamesListBox.SelectedItem.ToString() + " ?",
                    "Удаление заметки", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _project.Notes.Remove(_project.Notes.Find(note =>
                    note.Name.Equals(NoteNamesListBox.SelectedItem.ToString())));
                ProjectManager.SaveToFile(_project, Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\NoteApp\\NoteApp.notes");
                NoteNamesListBox.Items.Clear();
                foreach (var note in _project.Notes)
                {
                    NoteNamesListBox.Items.Add(note.Name);
                }
                NoteNamesListBox.SelectedItem = NoteNamesListBox.Items[0];
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About aboutInfo = new About();
            aboutInfo.Show();
        }

        private void NoteNamesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Note note = _project.Notes.Find(n => n.Name.Equals(NoteNamesListBox.SelectedItem.ToString()));
            NoteNameLabel.Text = note.Name;
            NoteTextbox.Text = note.Text;
            NoteCategory.Text = note.Category.ToString();
            CreationDateTime.Value = note.CreatedDate;
            ModifiedDateTime.Value = note.ModifidedDate;
        }

    }
}
