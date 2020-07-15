using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    /// <summary>
    /// Класс, содержащий коллекцию всех созданных заметок
    /// </summary>
    public class Project
    {
        /// <summary>
        /// Коллекция всех созданных записок
        /// </summary>
        private List<Note> _notes = new List<Note>();

        /// <summary>
        /// Доступ к коллекции записок
        /// </summary>
        public List<Note> Notes
        {
            get { return _notes; }
            set { _notes = value; }
        }

        /// <summary>
        /// Свойство для хранения текущей выбранной заметки
        /// </summary>
        public Note CurrentNote { set; get; }

        /// <summary>
        /// Сортировка заметок по убыванию даты последнего изменения
        /// </summary>
        /// <param name="notes">Сортеруемый список заметок</param>
        /// <returns>Возвращает отсортированный список заметок</returns>
        public List<Note> SortNotesByModifiedDate(List<Note> notes)
        {
            return notes.OrderByDescending(note => note.ModifidedDate).ToList();
        }


        /// <summary>
        /// Сортировка по убыванию даты последнего изменения с выборкой по категории
        /// </summary>
        /// <param name="notes">Сортируемый списое заметок</param>
        /// <param name="category">Категория выборки заметок</param>
        /// <returns>Возвращает отсортированный список заметок указанной категории</returns>
        public List<Note> SortNotesByModifiedDate(List<Note> notes, NoteCategory category)
        {
            List<Note> categoryNotes = new List<Note>();
            foreach (var note in notes)
            {
                if (note.Category == category)
                {
                    categoryNotes.Add(note);
                }
            }

            return SortNotesByModifiedDate(categoryNotes);
        }
    }
}
