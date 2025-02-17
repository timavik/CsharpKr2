using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace KrNumber5.Models
{
    public class JsonDataStorage<T> : IDataStorage<T>
    {
        public void SaveToFile(string filePath, IEnumerable<T> items)
        {
            string json = JsonSerializer.Serialize(items, new JsonSerializerOptions { WriteIndented = true });

            File.WriteAllText(filePath, json);
        }

        public List<T> LoadFromFile(string filePath)
        {
            if (!File.Exists(filePath))
                return new List<T>();

            string json = File.ReadAllText(filePath);

            return JsonSerializer.Deserialize<List<T>>(json) ?? new List<T>();
        }
    }
}
