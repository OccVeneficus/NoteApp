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
    public class NoteTest
    {
        private readonly DateTime _date = DateTime.Now;
        private Note _note;
        public void InitNote()
        {
            _note =  new Note(_date, DateTime.Now, "Testname", "Testtext", NoteCategory.Work);
        }

        [Test(Description = "Присвоение правильных данных в констуркторе заметки")]
        public void TestNoteConstructor_CorrectValues()
        {
            InitNote();
            var expectedName = "TestNoteName";
            var expectedText = "TestText";
            var expectedCategory = NoteCategory.Other;
            var expectedCreationDate = _date;
            var expectedModifiedDate = DateTime.Now;
            _note.Name = expectedName;
            _note.Text = expectedText;
            _note.Category = expectedCategory;
            _note.ModifidedDate = expectedModifiedDate;

            var actualName = _note.Name;
            Assert.AreEqual(expectedName, actualName, "Неверное присвоение названия заметки");
            var actualText = _note.Text;
            Assert.AreEqual(expectedText,actualText,"Неверное присвоение текста заметки");
            var actualCategory = _note.Category;
            Assert.AreEqual(expectedCategory,actualCategory,"Неверное присвоенеие категории заметки");
            var actualCreationDate = _note.CreatedDate;
            Assert.AreEqual(expectedCreationDate,actualCreationDate,"Неверное присвоение времени создания заметки");
            var actualModifiedDate = _note.ModifidedDate;
            Assert.AreEqual(expectedModifiedDate,actualModifiedDate,"Неверное присвоение даты последнего изменения");
        }

        [Test(Description = "Присвоение имени заметки больше 50 символов")]
        public void TestNameProperty_Longer50Symbols()
        {
            InitNote();
            Assert.Throws<Exception>(() => { _note.Name = "Test_Test_Test_Test_Test_Test_Test_Test_Test_Test_Test_Test_"; },
                "Должно возникать если название длиннее 50 символов");
        }

        [Test(Description = "Создание клона объекта")]
        public void TestNoteClone_Object()
        {
            InitNote();
            Note cloneNote = (Note) _note.Clone();
            Assert.AreNotSame(cloneNote,_note, "Не произошло копирование");
        }
    }

    [TestFixture]
    public class ProjectTest
    {
        private Project _project;

        public void InitProject()
        {
            _project = new Project();
        }

        [Test(Description = "Присвоение правильных данных в коллекцию проекта")]
        public void ProjectTest_CorrectValues()
        {
            InitProject();
            var expectedList = new List<Note>(){new Note(DateTime.Parse("2020-07-12T20:03:15.8537962+07:00"),
                DateTime.Parse("2020-07-12T20:03:15.8537962+07:00"),
                "TestDataNoteName", "SampleText", NoteCategory.Other)};
            _project.Notes = expectedList;
            Assert.AreEqual(expectedList,_project.Notes, "Неправильное присвоение коллекции");
        }
    }

    [TestFixture]
    public class ProjectManagerTest
    {
        private readonly string _testFileLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\TestData\\TestNoteApp.notes";
        private readonly string _corruptedFileLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\TestData\\CorruptedNoteApp.notes";
        private Note _testNote;

        public void InitTestNote()
        {
            _testNote = new Note(DateTime.Parse("2020-07-12T20:03:15.8537962+07:00"),
                DateTime.Parse("2020-07-12T20:03:15.8537962+07:00"),
                "TestDataNoteName", "SampleText", NoteCategory.Other);
        }

        [Test(Description = "Сохранение файла с эталонным проектом")]
        public void ProjectManagerSaveToFile_SaveTestFile()
        {
            InitTestNote();
            Project project = new Project();
            project.Notes.Add(_testNote);
            var location = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\TestData\\TestNoteAppSave.notes";
            if (File.Exists(location))
            {
                File.Delete(location);
            }
            ProjectManager.SaveToFile(project,location);
            Assert.IsTrue(File.Exists(location),"Файл не был создан");
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
            Assert.AreEqual(_testNote.ToString(),project.Notes[0].ToString(),"Загруженные данные не совпадают с эталоном");
        }
    }
}
