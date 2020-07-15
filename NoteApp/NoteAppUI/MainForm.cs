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
        /// <summary>
        /// Параметр для хранения проекта во время работы приложения
        /// </summary>
        private Project _project;

        private void UpdateData()
        {
            Note tempNote = _project.CurrentNote;
            NoteNamesListBox.DataSource = CategoryComboBox.SelectedItem.Equals("All")
                ? _project.SortNotesByModifiedDate(_project.Notes) 
                : _project.SortNotesByModifiedDate(_project.Notes, (NoteCategory) CategoryComboBox.SelectedItem);
            NoteNamesListBox.DisplayMember = "Name";
            _project.CurrentNote = tempNote;
        }

        private void SetCurrentNote()
        {
            Project project = new Project();
            project.Notes = (List<Note>)NoteNamesListBox.DataSource;
            int i = project.Notes.FindIndex(note =>
                note.Name.Equals(_project.CurrentNote.Name) &&
                note.CreatedDate.Equals(_project.CurrentNote.CreatedDate));
            if (i < 0)
            {
                return;
            }
            NoteNamesListBox.SetSelected(i, true);
            NoteNameLabel.Text = _project.CurrentNote.Name;
            NoteTextbox.Text = _project.CurrentNote.Text;
            NoteCategory.Text = _project.CurrentNote.Category.ToString();
            CreationDateTime.Value = _project.CurrentNote.CreatedDate;
            ModifiedDateTime.Value = _project.CurrentNote.ModifidedDate;
        }

        public MainForm()
        {
            InitializeComponent();

            foreach (var category in Enum.GetValues(typeof(NoteCategory)))
            {
                CategoryComboBox.Items.Add(category);
            }
            CategoryComboBox.Items.Add("All");

            _project = ProjectManager.LoadFromFile(ProjectManager.DefaultFilePath);

            NoteNamesListBox.SelectedIndexChanged -= NoteNamesListBox_SelectedIndexChanged;
            CategoryComboBox.SelectedItem = "All";
            SetCurrentNote();
            NoteNamesListBox.SelectedIndexChanged += NoteNamesListBox_SelectedIndexChanged;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NoteForm addEditNote = new NoteForm();
            addEditNote.Note = new Note(DateTime.Now, DateTime.Now,
                "No name", "", NoteApp.NoteCategory.Other);
            addEditNote.ShowDialog();
            if (addEditNote.DialogResult == DialogResult.OK)
            {
                _project.Notes.Add(addEditNote.Note);
                _project.CurrentNote = addEditNote.Note;
                UpdateData();
                ProjectManager.SaveToFile(_project, ProjectManager.DefaultFilePath);
            }
        }

        private void editNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_project.CurrentNote == null)
            {
                MessageBox.Show(@"Create new note with Edit button",
                    @"Note list is empty", MessageBoxButtons.OK);
                return;
            }
            Note selectedNoteCopy = (Note) _project.CurrentNote.Clone();
            NoteForm addEditNote = new NoteForm();
            addEditNote.Note = selectedNoteCopy;
            addEditNote.ShowDialog();
            if (addEditNote.DialogResult == DialogResult.OK)
            {
                _project.CurrentNote.Name = addEditNote.Note.Name;
                _project.CurrentNote.Text = addEditNote.Note.Text;
                _project.CurrentNote.Category = addEditNote.Note.Category;
                _project.CurrentNote.ModifidedDate = DateTime.Now;
                UpdateData();
                ProjectManager.SaveToFile(_project, ProjectManager.DefaultFilePath);
            }
        }

        private void deleteNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (NoteNamesListBox.SelectedItem == null)
            {
                MessageBox.Show(@"", @"Note list is empty", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show(@"You sure want to delete " + _project.CurrentNote.Name + " ?",
                    @"Delete note", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _project.Notes.Remove(_project.Notes.Find(note =>
                    note.Name.Equals(_project.CurrentNote.Name)&& note.CreatedDate.Equals(_project.CurrentNote.CreatedDate)));
                ProjectManager.SaveToFile(_project, ProjectManager.DefaultFilePath);
                NoteNamesListBox.Refresh();
                if (_project.Notes.Count != 0)
                {
                    NoteNamesListBox.SelectedItem = NoteNamesListBox.Items[0];
                    _project.CurrentNote = (Note) NoteNamesListBox.SelectedItem;
                }
                else
                {
                    NoteNamesListBox.SelectedItem = null;
                    _project.CurrentNote = null;
                    NoteNameLabel.ResetText();
                    NoteTextbox.ResetText();
                    CreationDateTime.Value = DateTime.Now;
                    ModifiedDateTime.Value = DateTime.Now;
                    NoteCategory.ResetText();
                }
                UpdateData();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About aboutInfo = new About();
            aboutInfo.Show();
        }

        private void NoteNamesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            _project.CurrentNote = _project.Notes.Find(note => note.Equals(NoteNamesListBox.SelectedItem));
            if (_project.CurrentNote == null)
            {
                return;
            }
            NoteNameLabel.Text = _project.CurrentNote.Name;
            NoteTextbox.Text = _project.CurrentNote.Text;
            NoteCategory.Text = _project.CurrentNote.Category.ToString();
            CreationDateTime.Value = _project.CurrentNote.CreatedDate;
            ModifiedDateTime.Value = _project.CurrentNote.ModifidedDate;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ProjectManager.SaveToFile(_project, ProjectManager.DefaultFilePath);
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateData();
        }
    }
}
