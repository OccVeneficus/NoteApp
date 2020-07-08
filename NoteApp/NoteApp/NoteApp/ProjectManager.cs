using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NoteApp
{
    /// <summary>
    /// Статический класс для сохранения и загрузки данных из файлов
    /// </summary>
    public static class ProjectManager
    {
        //TODO: посмотри на то, как я сделал в xml-комментарии ссылку на другой класс. Правильнее делать именно так, потому что: а) защита на случай переименования классов; б) кросс-ссылки в xml позволяют быстро перемещаться по документации к нужным классам
        /// <summary>
        /// Сохраняет объект <see cref="Project"/> в файл 
        /// </summary>
        /// <param name="project">Коллекция для сериализации</param> //TODO: это не коллекция. Это проект
        public static void SaveToFile(Project project)
        {
            //TODO: путь до файла надо передавать в метод, чтобы место сохранения выбирал клиентский код. Это позволяет использовать класс более гибко (например, если в программе добавятся несколько пользователей, сохранять их заметки в отдельных файлах)
            //TODO: при этом путь по-умолчанию удобнее хранить в качестве поля/свойства в самом менеджере.

            //TODO: путь "Мои Документы" плох тем, что пользователь может по неосторожности грохнуть файл с заметками,
            // правильнее сохранять данные в системной папке AppData, в которой создать подпапку для своей подпрограммы
            Directory.CreateDirectory(@"c:\My Documents");
            JsonSerializer serializer = new JsonSerializer();
            using (StreamWriter sw = new StreamWriter(@"c:\My Documents\NoteApp.notes"))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer,project);
            }
        }

        /// <summary>
        /// Загружает объект "Project" из файла
        /// </summary>
        /// <returns>Возвращает данные из файла преобразуя в объект "Project"</returns>
        public static Project LoadFromFile()
        {
            //TODO: путь до файла передавать в метод
            //TODO: использовать путь до AppData вместо моих документов
            Directory.CreateDirectory(@"c:\My Documents");
            JsonSerializer serializer = new JsonSerializer();
            //TODO: отработать вариант, если такой файл не существует, или файл не может быть десериализован
            using (StreamReader sr = new StreamReader(@"c:\My Documents\NoteApp.notes"))
            using (JsonReader reader = new JsonTextReader(sr))
            {
                return (Project) serializer.Deserialize<Project>(reader);
            }
        }
    }
}
