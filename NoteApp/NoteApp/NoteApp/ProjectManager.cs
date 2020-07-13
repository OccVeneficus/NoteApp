using System;
using System.Collections.Generic;
using System.Dynamic;
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
        /// <summary>
        /// Путь сохранения файла с проектом по умолчанию   
        /// </summary>
        public static string DefaultFilePath { get; private set; } = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\NoteApp\\NoteApp.notes";
        /// <summary>
        /// Сохраняет объект <see cref="Project"/> в файл 
        /// </summary>
        /// <param name="project">Проект для сериализации</param>
        /// <param name="path">Путь файла для сохранения/загрузки проекта</param>
        public static void SaveToFile(Project project, string path)
        {
            //TODO: при этом путь по-умолчанию удобнее хранить в качестве открытого поля/свойства в самом менеджере.
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
            //TODO: что за дублирование? Ты не так понял. Дефолтный путь хранится в виде ОТКРЫТОГО СВОЙСТВА менеджера.
            // клиентский код, вызывая сохранение файла, должен забрать значение свойства и передать его в метод сохранения.
            // Т.е. если клиентский код хочет, он использует дефолтный путь (который формируется строго в менеджере). А если не хочет, то передаёт любой свой.
            // При этом если во время сохранения произошла ошибка, то исключение должно обрабатываться на формах. А если бы ошибка возникла при загрузке, то нужно было бы просто вернуть пустой проект.
        }

        /// <summary>
        /// Загружает объект "Project" из файла
        /// </summary>
        /// <returns>Возвращает данные из файла преобразуя в объект "Project"</returns>
        public static Project LoadFromFile(string path)
        {
            JsonSerializer serializer = new JsonSerializer();

            if (!File.Exists(path))
            {
                //TODO: не нужно исключение, просто верни пустой проект. После первой установки ни одного пользователя не будет этого файла на компьютере, а из-за исключения этот файл никогда не будет создан. Поэтому логика должна быть такая - если файла нет, то просто создать пустой проект и продолжить работу.
                Project project = new Project();
                return project;
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
                //TODO: опять же - вернуть пустой проект вместо исключения.
                Project project = new Project();
                return project;
            }
        }
    }
}
