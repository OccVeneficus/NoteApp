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

        public List<Note> SortNotesByModifiedDate(List<Note> notes)
        {
            return notes.OrderByDescending(note => note.ModifidedDate).ToList();
        }

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
