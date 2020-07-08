using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
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
        /// <param name="project">Проект для сериализации</param> //TODO: это не коллекция. Это проект
        /// <param name="path">Путь файла для сохранения/загрузки проекта</param>
        public static void SaveToFile(Project project, string path)
        {
            //TODO: путь до файла надо передавать в метод, чтобы место сохранения выбирал клиентский код. Это позволяет использовать класс более гибко (например, если в программе добавятся несколько пользователей, сохранять их заметки в отдельных файлах)
            //TODO: при этом путь по-умолчанию удобнее хранить в качестве поля/свойства в самом менеджере.
            //TODO: путь "Мои Документы" плох тем, что пользователь может по неосторожности грохнуть файл с заметками,
            // правильнее сохранять данные в системной папке AppData, в которой создать подпапку для своей подпрограммы
            string defaultPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\NoteApp\\NoteApp.notes";
            try
            {
                if (!Directory.Exists(Path.GetDirectoryName(path)))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(path));
                }
                JsonSerializer serializer = new JsonSerializer();
                using (StreamWriter sw = new StreamWriter(path))
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    serializer.Serialize(writer, project);
                }
            }
            catch (JsonException)
            {
                if (!Directory.Exists(Path.GetDirectoryName(defaultPath)))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(defaultPath));
                }
                JsonSerializer serializer = new JsonSerializer();
                using (StreamWriter sw = new StreamWriter(defaultPath))
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    serializer.Serialize(writer, project);
                }
            }
        }

        /// <summary>
        /// Загружает объект "Project" из файла
        /// </summary>
        /// <returns>Возвращает данные из файла преобразуя в объект "Project"</returns>
        public static Project LoadFromFile(string path)
        {
            //TODO: путь до файла передавать в метод
            //TODO: использовать путь до AppData вместо моих документов
            //TODO: отработать вариант, если такой файл не существует, или файл не может быть десериализован
            JsonSerializer serializer = new JsonSerializer();
            if (!File.Exists(path))
            {
                throw new Exception("File do not exist");
            }
            try
            {
                using (StreamReader sr = new StreamReader(path))
                using (JsonReader reader = new JsonTextReader(sr))
                {
                    return (Project) serializer.Deserialize<Project>(reader);
                }
            }
            catch (JsonSerializationException)
            {
                throw new Exception("Can not access file");
            }
        }
    }
}
