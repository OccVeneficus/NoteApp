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
        }
    }
}
