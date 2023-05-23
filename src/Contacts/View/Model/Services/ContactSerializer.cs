using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace View.Model.Services
{
    /// <summary>
    /// Предоставляет методы для сериализации данных о контакте.
    /// </summary>
    public static class ContactSerializer
    {
        /// <summary>
        /// Возвращает и задает путь к файлу.
        /// </summary>
        public static string Filename { get; set; }

        /// <summary>
        /// Создает экземпляр класса <see cref="ContactSerializer"/>
        /// </summary>
        static ContactSerializer()
        {
            var myDocumentsFolder =
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) +
                @"\Contacts\contacts.json";
            Filename = myDocumentsFolder;
        }

        /// <summary>
        /// Проверяет, существует ли папка, указанная в свойстве Filename.
        /// И, если папка не существует, то создает папку.
        /// </summary>
        public static void CreateDirectory()
        {
            if (!Directory.Exists(Filename))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(Filename));
            }
        }

        /// <summary>
        /// Сохраняет данные о товарах в файл.
        /// </summary>
        /// <param name="contacts">Данные о контактах, которые нужно сохранить.</param>
        /// <exception cref="Exception">Возникает, 
        /// если произошла ошибка при сохранении.</exception>
        public static void SaveToFile(ObservableCollection<Contact> contacts)
        {
            CreateDirectory();
            var settings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All
            };
            JsonSerializer serializer = new JsonSerializer();
            serializer = JsonSerializer.Create(settings);
            using (StreamWriter sw = new StreamWriter(Filename))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, contacts);
            }
        }

        /// <summary>
        /// Загружает данные из файла и передает их в список.
        /// </summary>
        /// <returns>Возвращает текущий контакт.</returns>
        public static ObservableCollection<Contact> LoadFromFile()
        {
            ObservableCollection<Contact> contacts = null;

            try
            {
                CreateDirectory();
                var settings = new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.All
                };
                JsonSerializer serializer = new JsonSerializer();
                serializer = JsonSerializer.Create(settings);
                using (StreamReader sr = new StreamReader(Filename))
                using (JsonReader reader = new JsonTextReader(sr))
                {
                    contacts = serializer.Deserialize<ObservableCollection<Contact>>(reader);

                    if(contacts == null)
                    {
                        return new ObservableCollection<Contact>();
                    }
                }
            }
            catch
            {
                return new ObservableCollection<Contact>();
            }

            return contacts;
        }
    }
}
