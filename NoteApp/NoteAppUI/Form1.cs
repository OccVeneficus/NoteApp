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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Note note = new Note();
        Project project = new Project();
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.AppendText(note.Name + "\n");
            richTextBox1.AppendText(note.Text + "\n");
            richTextBox1.AppendText(note.Category.ToString()+ "\n");
            richTextBox1.AppendText(note.CreatedDate.ToString("d") + "\n");
            richTextBox1.AppendText(note.ModifidedDate.ToString("d") + "\n");
            richTextBox1.AppendText("--------------------------\n");
            note.Name = "New note name";
            note.Text = "Sample text";
            note.Category = NoteCategory.Documents;
            richTextBox1.AppendText(note.Name + "\n");
            richTextBox1.AppendText(note.Text + "\n");
            richTextBox1.AppendText(note.Category.ToString() + "\n");
            richTextBox1.AppendText(note.CreatedDate.ToString("d") + "\n");
            richTextBox1.AppendText(note.ModifidedDate.ToString("d") + "\n");
            project.Notes.Add(note);
            ProjectManager.SaveToFile(project);
            Project loadProject = ProjectManager.LoadFromFile();
            richTextBox1.AppendText("Файл сохранен и загружен в папку My Documents\n");
            richTextBox1.AppendText(loadProject.Notes.ElementAt(0).Text.ToString());
        }
    }
}
