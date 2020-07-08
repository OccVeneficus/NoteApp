using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    /// <summary>
    /// Класс заметки, хранящий ее название, категорю, текст, дату создания и последнего
    /// изменения
    /// </summary>
    public class Note : ICloneable
    {
        /// <summary>
        /// Название заметки
        /// </summary>
        private string _name; //TODO: одна пустая строка между членами класса - исправить здесь и везде далее
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
                _modifiedDate = DateTime.Today; //TODO: здесь и везде лучше использовать DateTime.Now - на случай сравнения между собой даты создания и даты редактирования наличие времени вплоть до миллисекунд лучше чем просто дата
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
                _modifiedDate = DateTime.Today;
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
        public DateTime CreatedDate
        {
            private set
            {
                _createdDate = DateTime.Today;
            }
            get
            {
                return _createdDate;
            }
        }
        /// <summary>
        /// Дата последнего изменения заметки
        /// </summary>
        private DateTime _modifiedDate;
        /// <summary>
        /// Возвращает дату последнего изменения параметров заметки
        /// </summary>
        public DateTime ModifidedDate
        {
            private set
            {
                _modifiedDate = DateTime.Today;
            }
            get
            {
                return _modifiedDate;
            }
        }
        /// <summary>
        /// Реализация интерфейса IClone
        /// </summary>
        /// <returns>Возвращает новый экземпляр-копию текущего объекта</returns>
        public object Clone()
        {
            return new Note 
            { 
                Name = this.Name,
                Category = this.Category,
                Text = this.Text,
                ModifidedDate = this.ModifidedDate,
                CreatedDate = this.CreatedDate

            };
        }
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Note()
        {
            this.Name = "No name";
            this.Text = "";
            this.Category = NoteCategory.Other;
            this.CreatedDate = DateTime.Today;
            this.ModifidedDate = DateTime.Today;
        }
    }
}
