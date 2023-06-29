using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Storage<T>
    {
        private T[] _storage;
        private int _addSize;

        public Storage()
        {
            _addSize = 0;
            this._storage = new T[_addSize];
        }

        public void Add(T item)
        {
            _addSize++;
            Array.Resize(ref _storage, _addSize);
            _storage[_addSize-1] = item;
        }

        public void Remove(T item)
        {
            int index = Array.IndexOf(_storage, item);
            if (index >= 0)
            {
                for (int i = index; i < _addSize - 1; i++)
                {
                    _storage[i] = _storage[i + 1];
                }

                Array.Resize(ref _storage, _addSize - 1);
                _addSize--;
            }
        }

        public void Update(T currentItem, T newItem)
        {
            int index = Array.IndexOf(_storage, currentItem);
            if(index >= 0)
            {
                for(int i = index; i < _addSize - 1; i++)
                {
                    _storage[i] = newItem;
                }
            }
        }

        public void PrintItems()
        {
            foreach (T item in _storage)
            {
                Console.WriteLine(item);
            }
        }
    }
}
