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
//TODO: маленькие поля у формы на верстке
//TODO: не стандартные расстояния между элементами (наппример, межстрочные)
//TODO: текст лейблов не выровнен относительно полей, к которым они привязаны
//TODO: эти же замечания ко второй форме
{ //TODO: название файла не соответствует имени класса
    public partial class MainForm : Form
    { //TODO: xml
        private Project _project;

        public MainForm()
        {
            InitializeComponent();

            foreach (var category in Enum.GetValues(typeof(NoteCategory)))
            {
                CategoryComboBox.Items.Add(category);
            }
            CategoryComboBox.Items.Add("All");

            try
            { //TODO: путь должен формироваться в бизнес-логике (см. замечания в менеджере)
                _project = ProjectManager.LoadFromFile(
                    Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\NoteApp\\NoteApp.notes");
            }
            catch (Exception)
            {
                //TODO: пустые проекты должен создавать менеджер. Чем больше логики не связанной с интерфейсом будет в проекте бизнес-логики, тем лучше
                _project = new Project();
            }

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
            //TODO: при закрытии формы не происходит сохранения данных. Надо сделать сохранение при ЛЮБЫХ вариантах завершения программы
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
                //TODO: путь должен быть в менеджере
                ProjectManager.SaveToFile(_project, Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\NoteApp\\NoteApp.notes");
            }
        }

        private void editNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Note selectedNote = _project.Notes.Find(note => note.Name.Equals(NoteNamesListBox.SelectedItem.ToString())
                                                            && note.CreatedDate.Equals(CreationDateTime.Value));
            Note selectedNoteCopy = (Note) selectedNote.Clone();
            NoteForm addEditNote = new NoteForm();
            addEditNote.TempNote = selectedNoteCopy;
            addEditNote.ShowDialog();
            if (addEditNote.DialogResult == DialogResult.OK)
            {
                selectedNote.Name = addEditNote.TempNote.Name;
                selectedNote.Text = addEditNote.TempNote.Text;
                selectedNote.Category = addEditNote.TempNote.Category;
                selectedNote.ModifidedDate = DateTime.Now;
                NoteNamesListBox.Items.Clear();
                foreach (var note in _project.Notes)
                {
                    NoteNamesListBox.Items.Add(note.Name);
                }
                //TODO: опять путь формируется здесь
                ProjectManager.SaveToFile(_project, Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\NoteApp\\NoteApp.notes");
                NoteNamesListBox.SelectedItem = addEditNote.TempNote.Name;
            }
        }

        private void deleteNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы точно хотите удалить " + NoteNamesListBox.SelectedItem.ToString() + " ?",
                    "Удаление заметки", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _project.Notes.Remove(_project.Notes.Find(note =>
                    note.Name.Equals(NoteNamesListBox.SelectedItem.ToString())));
                //TODO: опять путь. Теперь очевиден недостаток такого решения?
                ProjectManager.SaveToFile(_project, Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\NoteApp\\NoteApp.notes");
                NoteNamesListBox.Items.Clear();
                foreach (var note in _project.Notes)
                {
                    NoteNamesListBox.Items.Add(note.Name);
                }
                if (_project.Notes.Count != 0)
                {
                    NoteNamesListBox.SelectedItem = _project.Notes[0].Name;
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

    }
}
