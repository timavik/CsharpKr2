using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace KrNumber5.Models
{
    public interface IDataStorage<T>
    {
        void SaveToFile(string filePath, IEnumerable<T> items);
        List<T> LoadFromFile(string filePath);
    }

    public interface IEntityRepository<T>
    {
        void Add(T item);
        void Update(int index, T newItem);
        void Delete(int index);
        T Get(int index);
        List<T> GetAll();
    }
}
