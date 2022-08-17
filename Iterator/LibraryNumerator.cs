using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    internal class LibraryNumerator : IBookIterator
    {
        IBookNumerable _aggregate;
        int index = 0;

        public LibraryNumerator(IBookNumerable aggregator)
        {
            _aggregate = aggregator;
        }
        public bool HasNext()
        {
            return index < _aggregate.Count;
        }

        public Book Next()
        {
            return _aggregate[index++];
        }
    }
}
