using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NoteApp;

namespace UnitTests
{
    [TestFixture]
    public class NoteTest
    {
        private Note _note;
        private readonly DateTime _date = DateTime.Now;

        [SetUp]
        public void InitNote()
        {
            _note = new Note(_date, DateTime.Now, "Testname","Testtext",NoteCategory.Work);
        }

        [Test(Description = "Присвоение правильных данных в констуркторе заметки")]
        public void TestNoteConstructor_CorrectValues()
        {
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

            Assert.Throws<Exception>(() => { _note.Name = "Test_Test_Test_Test_Test_Test_Test_Test_Test_Test_Test_Test_"; },
                "Должно возникать если название длиннее 50 символов");
        }

        [Test(Description = "Создание клона объекта")]
        public void TestNoteClone_Object()
        {
            Note cloneNote = (Note) _note.Clone();
            Assert.AreNotSame(cloneNote,_note, "Не произошло копирование");
        }
    }

    [TestFixture]
    public class ProjectTest
    {

    }

    [TestFixture]
    public class ProjectManagerTest
    {

    }
}
