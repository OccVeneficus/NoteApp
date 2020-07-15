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
    //TODO: после редактирования названия заметки, её название не меняется в листбоксе главного окна
    //TODO: при запуске программы в листбоксе выбрана заметка, но она не показывается на правой панели
    //TODO: текстовое поле с текстом заметки слишком близко к полям окна - стоит впритык к нижней и правой границам. Все поля должны быть одинаковые
    public partial class MainForm : Form
    {
        /// <summary>
        /// Параметр для хранения проекта во время работы приложения
        /// </summary>
        private Project _project;

        private void UpdateCategoryListBox() //TODO: слишком абстрактное название
        {
            Note tempNote = _project.CurrentNote;
            List<Note> tempNotes = CategoryComboBox.SelectedItem.Equals("All")
                ? _project.SortNotesByModifiedDate(_project.Notes)
                : _project.SortNotesByModifiedDate(_project.Notes, (NoteCategory)CategoryComboBox.SelectedItem);
            NoteNamesListBox.DataSource = tempNotes;
            NoteNamesListBox.DisplayMember = "Name";
            _project.CurrentNote = tempNote;
            if (tempNotes.Count != 0)
            {
                int index = tempNotes.FindIndex(note =>
                    note.Name.Equals(_project.CurrentNote.Name) &&
                    note.CreatedDate.Equals(_project.CurrentNote.CreatedDate));
                if (index >= 0)
                {
                    NoteNamesListBox.SelectedItem = NoteNamesListBox.Items[index];
                }
                else
                {
                    _project.CurrentNote = tempNotes[0];
                }
            }
        }

        public MainForm()
        {
            InitializeComponent();
            //TODO: AddRange?
            foreach (var category in Enum.GetValues(typeof(NoteCategory)))
            {
                CategoryComboBox.Items.Add(category);
            }
            CategoryComboBox.Items.Add("All");

            _project = ProjectManager.LoadFromFile(ProjectManager.DefaultFilePath);
            _project.Notes = _project.SortNotesByModifiedDate(_project.Notes);

            //TODO: временная отписка от событий - признак костыля. Попробуй сделать по-другому
            CategoryComboBox.SelectedItem = "All";
            if (_project.Notes.Count != 0)
            {
                NoteNamesListBox.SelectedItem = NoteNamesListBox.Items[
                    _project.Notes.FindIndex(note =>
                        note.Name.Equals(_project.CurrentNote.Name) &&
                        note.CreatedDate.Equals(_project.CurrentNote.CreatedDate))];
            }
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
                UpdateCategoryListBox();
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
                UpdateCategoryListBox();
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
                UpdateCategoryListBox();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About aboutInfo = new About();
            aboutInfo.ShowDialog(); //TODO: зачем пользователю переключаться с окна эбаут?
        }

        private void NoteNamesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //TODO: если выбранный индекс -1? (пустой список в листбоксе)
            //TODO: а если две заметки с одинаковым именем? Это надежный способ определения заметки?
            _project.CurrentNote = NoteNamesListBox.SelectedItem as Note;
            if (_project.CurrentNote == null || NoteNamesListBox.SelectedIndex < 0)
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
            UpdateCategoryListBox();
        }
    }
}
