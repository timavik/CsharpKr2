using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrNumber5.Models
{
    using System.Collections.Generic;

    public class InMemoryRepository<T> : IEntityRepository<T>
    {
        private readonly List<T> _items = new List<T>();

        public void Add(T item)
        {
            _items.Add(item);
        }

        public void Update(int index, T newItem)
        {
            if (index < 0 || index >= _items.Count)
                throw new IndexOutOfRangeException("Invalid index");

            _items[index] = newItem;
        }

        public void Delete(int index)
        {
            if (index < 0 || index >= _items.Count)
                throw new IndexOutOfRangeException("Invalid index");

            _items.RemoveAt(index);
        }

        public T Get(int index)
        {
            if (index < 0 || index >= _items.Count)
                throw new IndexOutOfRangeException("Invalid index");

            return _items[index];
        }

        public List<T> GetAll()
        {
            return new List<T>(_items);
        }
    }
}
