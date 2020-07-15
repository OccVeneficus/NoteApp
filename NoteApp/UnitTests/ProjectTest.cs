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
    }
}
