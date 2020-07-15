using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NoteApp;


namespace UnitTests
{
    [TestFixture]
    public class ProjectManagerTest
    {
        private readonly string _testFileLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\TestData\\TestNoteApp.notes";
        private readonly string _corruptedFileLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\TestData\\CorruptedNoteApp.notes";
        private Note _testNote;

        public void InitTestNote()
        {
            _testNote = new Note(DateTime.Parse("2020-07-15T11:22:17.4984499+07:00"),
                DateTime.Parse("2020-07-15T11:22:17.4984499+07:00"),
                "3", "3", NoteCategory.HealthAndSport);
        }

        [Test(Description = "Сохранение файла с эталонным проектом")]
        public void ProjectManagerSaveToFile_SaveTestFile()
        {
            InitTestNote();
            Project project = new Project();
            project.Notes.Add(_testNote);
            project.CurrentNote = _testNote;
            var location = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\TestData\\TestNoteAppSave.notes";
            if (File.Exists(location))
            {
                File.Delete(location);
            }
            ProjectManager.SaveToFile(project, location);
            Assert.IsTrue(File.Exists(location), "Файл не был создан");
            Assert.AreEqual(File.ReadAllText(location), File.ReadAllText(_testFileLocation), "Содержание созданного файла отличается от эталонного");
        }

        [Test(Description = "Загрузка поврежденного файла")]
        public void ProjectManagerLoad_CorruptedFile()
        {
            Project project = ProjectManager.LoadFromFile(_corruptedFileLocation);
            Assert.IsEmpty(project.Notes, "В проект загруженны поврежденные данные");
        }

        [Test(Description = "Загрузка несуществующего файла")]
        public void ProjectManagerLoad_NotExistFile()
        {
            Project project = ProjectManager.LoadFromFile("");
            Assert.IsEmpty(project.Notes, "В проект загруженны неизвестные данные");
        }

        [Test(Description = "Загрузка эталонного файла")]
        public void ProjectManagerLoad_TestFile()
        {
            InitTestNote();
            Project project = ProjectManager.LoadFromFile(_testFileLocation);
            Assert.AreEqual(_testNote.ToString(), project.Notes[0].ToString(), "Загруженные данные не совпадают с эталоном");
        }
    }
}
