using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace advent.Collections
{
    public class Ring<T> : IRing<T>
    {
        public Ring() : this(new List<T>())
        {
            
        }

        public Ring(IList<T> list)
        {
            _list = list;
        }

        public Ring(IEnumerable<T> collection) : this(collection.ToList())
        {
            
        }


        protected readonly IList<T> _list;

        public IEnumerator<T> GetEnumerator()
        {
            return _list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _list.GetEnumerator();
        }

        public void Add(T item)
        {
            _list.Add(item);
        }

        public void Clear()
        {
            _list.Clear();
        }

        public bool Contains(T item)
        {
            return _list.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            _list.CopyTo(array, arrayIndex);
        }

        public bool Remove(T item)
        {
            return _list.Remove(item);
        }

        public int Count => _list.Count;

        public bool IsReadOnly => _list.IsReadOnly;

        public int IndexOf(T item)
        {
            return _list.IndexOf(item);
        }

        public void Insert(int index, T item)
        {
            _list.Insert(index % Count, item);
        }

        public void RemoveAt(int index)
        {
            _list.RemoveAt(index % Count);
        }

        public T this[int index]
        {
            get => _list[index % Count];
            set => _list[index % Count] = value;
        }
    }
}
