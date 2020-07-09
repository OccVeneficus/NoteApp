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
    public partial class MainMenu : Form
    {
        private Project project;

        public MainMenu()
        {
            InitializeComponent();
            foreach (var category in Enum.GetValues(typeof(NoteCategory)))
            {
                CategoryComboBox.Items.Add(category);
            }
            CategoryComboBox.Items.Add("All");
            try
            {
                project = ProjectManager.LoadFromFile(
                    Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\NoteApp\\NoteApp.notes");
            }
            catch (Exception)
            {
                project = new Project();
            }

            foreach (var note in project.Notes)
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
            AddEditNote addEditNote = new AddEditNote
            {
                TempProject = project,
            };
            addEditNote.ShowDialog();
            var updatedProject = addEditNote.TempProject;
            ProjectManager.SaveToFile(updatedProject, Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\NoteApp\\NoteApp.notes");
        }

        private void editNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEditNote addEditNote = new AddEditNote();
            addEditNote.ShowDialog();
        }

        private void deleteNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About aboutInfo = new About();
            aboutInfo.Show();
        }

        private void NoteNamesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Note note = project.Notes.Find(n => n.Name.Equals(NoteNamesListBox.SelectedItem.ToString()));
            NoteNameLabel.Text = note.Name;
            NoteTextbox.Text = note.Text;
            NoteCategory.Text = note.Category.ToString();
            CreationDateTime.Value = note.CreatedDate;
            ModifiedDateTime.Value = note.ModifidedDate;
        }

    }
}
