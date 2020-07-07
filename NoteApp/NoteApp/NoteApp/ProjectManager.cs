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
        /// <summary>
        /// Сохраняет объект "Project" в файл 
        /// </summary>
        /// <param name="project">Коллекция для сериализации</param>
        public static void SaveToFile(Project project)
        {
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
            Directory.CreateDirectory(@"c:\My Documents");
            JsonSerializer serializer = new JsonSerializer();
            using (StreamReader sr = new StreamReader(@"c:\My Documents\NoteApp.notes"))
            using (JsonReader reader = new JsonTextReader(sr))
            {
                return (Project) serializer.Deserialize<Project>(reader);
            }
        }
    }
}
