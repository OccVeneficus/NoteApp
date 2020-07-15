using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NoteApp
{
    //TODO: дата модификации не меняется автоматически при изменении значений других полей. Проконтролировать, что после автоматического изменения даты модификации, дата будет правильно загружаться из файла при десериализации
    /// <summary>
    /// Класс заметки, хранящий ее название, категорю, текст, дату создания и последнего
    /// изменения
    /// </summary>
    public class Note : ICloneable
    {
        /// <summary>
        /// Название заметки
        /// </summary>
        private string _name;

        /// <summary>
        /// Задает/возвращает название заметки размером не более 50 символов
        /// </summary>
        public string Name
        {
            set
            {
                if (value.Length > 50)
                {
                    throw new Exception("Name contains more than 50 characters");
                }

                _name = value;
            }
            get
            {
                return _name;
            }
        }

        /// <summary>
        /// Задает/возвращает текст заметки
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Категория заметки
        /// </summary>
        private NoteCategory _category;

        /// <summary>
        /// Задает/возвращает категорию заметки
        /// </summary>
        public NoteCategory Category
        {
            set
            {
                _category = value;
            }
            get
            {
                return _category;
            }
        }

        /// <summary>
        /// Дата создания заметки
        /// </summary>
        private DateTime _createdDate;

        /// <summary>
        /// Возвращает дату создания заметки
        /// </summary>
        public DateTime CreatedDate { private set; get; } //TODO: здесь и везде - сначала гет, потом сет. Поправить везде

        /// <summary>
        /// Дата последнего изменения заметки
        /// </summary>
        private DateTime _modifiedDate;

        /// <summary>
        /// Возвращает дату последнего изменения параметров заметки
        /// </summary>
        
        public DateTime ModifidedDate { set; get; }

        /// <summary>
        /// Реализация интерфейса IClone
        /// </summary>
        /// <returns>Возвращает новый экземпляр-копию текущего объекта</returns>
        public object Clone()
        {
            var noteClone = new Note(this.CreatedDate, this.ModifidedDate, this.Name, this.Text, this.Category);
            return noteClone;
        }

        /// <summary>
        /// Конструктор класса. Используется сериализатором JSON
        /// </summary>
        /// <param name="createdDate">Дата создания заметки</param>
        /// <param name="modifiedDate">Дата последнего изменения заметки</param>
        /// <param name="name">Название заметки</param>
        /// <param name="text">Текст заметки</param>
        /// <param name="category">Категория <see cref="NoteCategory"/> заметки</param>
        [JsonConstructor]
        public Note(DateTime createdDate, DateTime modifiedDate, string name, string text, NoteCategory category)
        {
            this.CreatedDate = createdDate;
            this.ModifidedDate = modifiedDate;
            this.Name = name;
            this.Text = text;
            this.Category = category;
        }

    }
}
