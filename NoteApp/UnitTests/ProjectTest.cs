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
    public class ProjectTest //TODO: добавить тесты на сортировку
    {
        private Project _project;

        public void InitProject()
        {
            _project = new Project();
            _project.Notes.Add(new Note(DateTime.Parse("2020-07-11T20:03:15.8537962+07:00"),
                DateTime.Parse("2020-07-11T20:03:15.8537962+07:00"),
                "1", "1", NoteCategory.Other));
            _project.Notes.Add(new Note(DateTime.Parse("2020-07-10T20:03:15.8537962+07:00"),
                DateTime.Parse("2020-07-13T20:03:15.8537962+07:00"),
                "2", "2", NoteCategory.Home));
            _project.Notes.Add(new Note(DateTime.Parse("2020-07-13T20:03:15.8537962+07:00"),
                DateTime.Parse("2020-07-10T20:03:15.8537962+07:00"),
                "3", "3", NoteCategory.Home));
            _project.Notes[0].ModifidedDate = DateTime.Parse("2020-07-11T20:03:15.8537962+07:00");
            _project.Notes[1].ModifidedDate = DateTime.Parse("2020-07-10T20:03:15.8537962+07:00");
            _project.Notes[2].ModifidedDate = DateTime.Parse("2020-07-15T20:03:15.8537962+07:00");
        }

        [Test(Description = "Присвоение правильных данных в коллекцию проекта")]
        public void ProjectTest_CorrectValues()
        {
            InitProject();
            var expectedList = new List<Note>(){new Note(DateTime.Parse("2020-07-12T20:03:15.8537962+07:00"),
                DateTime.Parse("2020-07-12T20:03:15.8537962+07:00"),
                "TestDataNoteName", "SampleText", NoteCategory.Other)};
            _project.Notes = expectedList;
            Assert.AreEqual(expectedList, _project.Notes, "Неправильное присвоение коллекции");
        }

        [Test(Description = "Тест метода сортировки по убыванию даты")]
        public void Project_SortByModifiedDateTest()
        {
            InitProject();
            IEnumerable <DateTime> expected = new[]
            {
                DateTime.Parse("2020-07-15T20:03:15.8537962+07:00"),
                DateTime.Parse("2020-07-11T20:03:15.8537962+07:00"),
                DateTime.Parse("2020-07-10T20:03:15.8537962+07:00")
            };
            List<Note> sortedNotes = _project.SortNotesByModifiedDate(_project.Notes);
            Assert.IsTrue(sortedNotes.Select(n =>n.ModifidedDate).SequenceEqual(expected), "Список отсортирован неверно");
        }

        [Test(Description = "Тест метода сортировки по времени с выборкой по категории")]
        public void Project_SortByModifiedDateCategoryTest()
        {
            InitProject();
            IEnumerable<DateTime> expected = new[]
            {
                DateTime.Parse("2020-07-15T20:03:15.8537962+07:00"),
                DateTime.Parse("2020-07-10T20:03:15.8537962+07:00")
            };
            List<Note> sortedNotes = _project.SortNotesByModifiedDate(_project.Notes, NoteCategory.Home);
            foreach (var note in sortedNotes)
            {
                Assert.AreEqual(NoteCategory.Home,note.Category, "Неправильная выборка по категории");
            }
            Assert.IsTrue(sortedNotes.Select(n => n.ModifidedDate).SequenceEqual(expected), "Список отсортирован неверно");
        }
    }
}
