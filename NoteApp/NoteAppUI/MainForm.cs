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

        public MainForm()
        {
            InitializeComponent();

            foreach (var category in Enum.GetValues(typeof(NoteCategory)))
            {
                CategoryComboBox.Items.Add(category);
            }
            CategoryComboBox.Items.Add("All");

            _project = ProjectManager.LoadFromFile(ProjectManager.DefaultFilePath);

            foreach (var note in _project.Notes)
            {
                NoteNamesListBox.Items.Add(note.Name);
            }

            if (_project.Notes.Count != 0)
            {
                NoteNamesListBox.SelectedItem = _project.Notes[0].Name;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NoteForm addEditNote = new NoteForm();
            addEditNote.OpenNote = new Note(DateTime.Now, DateTime.Now, "No name", "", NoteApp.NoteCategory.Other);
            addEditNote.ShowDialog();
            if (addEditNote.DialogResult == DialogResult.OK)
            {
                _project.Notes.Add(addEditNote.OpenNote);
                NoteNamesListBox.Items.Add(addEditNote.OpenNote.Name);
                ProjectManager.SaveToFile(_project, ProjectManager.DefaultFilePath);
            }
        }

        private void editNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Note selectedNote = _project.Notes.Find(note => note.Name.Equals(NoteNamesListBox.SelectedItem.ToString())
                                                            && note.CreatedDate.Equals(CreationDateTime.Value));
            if (selectedNote == null)
            {
                MessageBox.Show("Список заметок пуст. Создайте новою заметку с помощью кнопки edit.",
                    "Заметки отсутствуют", MessageBoxButtons.OK);
                return;
            }
            Note selectedNoteCopy = (Note) selectedNote.Clone();
            NoteForm addEditNote = new NoteForm();
            addEditNote.OpenNote = selectedNoteCopy;
            addEditNote.ShowDialog();
            if (addEditNote.DialogResult == DialogResult.OK)
            {
                selectedNote.Name = addEditNote.OpenNote.Name;
                selectedNote.Text = addEditNote.OpenNote.Text;
                selectedNote.Category = addEditNote.OpenNote.Category;
                selectedNote.ModifidedDate = DateTime.Now;
                NoteNamesListBox.Items.Clear();
                foreach (var note in _project.Notes)
                {
                    NoteNamesListBox.Items.Add(note.Name);
                }
                ProjectManager.SaveToFile(_project, ProjectManager.DefaultFilePath);
                NoteNamesListBox.SelectedItem = addEditNote.OpenNote.Name;
            }
        }

        private void deleteNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (NoteNamesListBox.SelectedItem == null)
            {
                MessageBox.Show("Список заметок пуст", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Вы точно хотите удалить " + NoteNamesListBox.SelectedItem.ToString() + " ?",
                    "Удаление заметки", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _project.Notes.Remove(_project.Notes.Find(note =>
                    note.Name.Equals(NoteNamesListBox.SelectedItem.ToString())));
                ProjectManager.SaveToFile(_project, ProjectManager.DefaultFilePath);
                NoteNamesListBox.Items.Clear();
                foreach (var note in _project.Notes)
                {
                    NoteNamesListBox.Items.Add(note.Name);
                }
                if (_project.Notes.Count != 0)
                {
                    NoteNamesListBox.SelectedItem = _project.Notes[0].Name;
                }
                else
                {
                    NoteNamesListBox.SelectedItem = null;
                    NoteNameLabel.ResetText();
                    NoteTextbox.ResetText();
                    CreationDateTime.Value = DateTime.Now;
                    ModifiedDateTime.Value = DateTime.Now;
                    NoteCategory.ResetText();
                }
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About aboutInfo = new About();
            aboutInfo.Show();
        }

        private void NoteNamesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Note currentNote = _project.Notes.Find(note => note.Name.Equals(NoteNamesListBox.SelectedItem.ToString()));
            NoteNameLabel.Text = currentNote.Name;
            NoteTextbox.Text = currentNote.Text;
            NoteCategory.Text = currentNote.Category.ToString();
            CreationDateTime.Value = currentNote.CreatedDate;
            ModifiedDateTime.Value = currentNote.ModifidedDate;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ProjectManager.SaveToFile(_project, ProjectManager.DefaultFilePath);
        }
    }
}
