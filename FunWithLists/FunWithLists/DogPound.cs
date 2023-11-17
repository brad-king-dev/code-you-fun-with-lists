using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FunWithLists
{
    public class DogPound : IList<Dog>
    {
        private Dog[] _dogArray = new Dog[] { };

        public Dog this[int index]
        {
            get { return _dogArray[index]; }
            set { _dogArray[index] = value; }
        }

        

        public int Count => _dogArray.Count();

        public bool IsReadOnly => false;

        public void Add(Dog item)
        {
            Array.Resize(ref _dogArray, _dogArray.Length+1);
            _dogArray[_dogArray.Length-1] = item;
        }

        public void Clear()
        {
            _dogArray = new Dog[] { };
        }

        public bool Contains(Dog item)
        {
            return _dogArray.Any(x => x.Equals(item));
        }

        public void CopyTo(Dog[] array, int arrayIndex)
        {
            _dogArray.CopyTo(array, arrayIndex);
        }

        public int IndexOf(Dog item)
        {
            for(int i = 0; i < _dogArray.Length; i++)
            {
                if (_dogArray[i].Equals(item)) 
                    return i;
            }

            return -1;
        }

        public void Insert(int index, Dog item)
        {
            var newArray = new Dog[_dogArray.Length+1];
            for(int i = 0; i < newArray.Length; i++)
            {
                if (i < index)
                {
                    newArray[i] = _dogArray[i];
                }
                else if (i == index)
                {
                    newArray[i] = item;
                }
                else if(i > index)
                {
                    newArray[i] = _dogArray[i-1];
                }
            }

            _dogArray = newArray;
        }

        public bool Remove(Dog item)
        {
            var foundForRemoval = false;
            var newArray = new Dog[_dogArray.Length - 1];
            for (int i = 0; i < _dogArray.Length; i++)
            {
                if (_dogArray[i] == item)
                {
                    foundForRemoval = true;
                    continue;
                }
                if(!foundForRemoval)
                {
                    newArray[i] = _dogArray[i];
                }
                else
                {
                    newArray[i-1] = _dogArray[i];
                }
            }
            _dogArray = newArray;
            return foundForRemoval;
        }

        public void RemoveAt(int index)
        {
            var newArray = new Dog[_dogArray.Length - 1];
            for (int i = 0; i < _dogArray.Length; i++)
            {
                if (i < index)
                {
                    newArray[i] = _dogArray[i];
                }
                else if (i > index)
                {
                    newArray[i-1] = _dogArray[i];
                }
            }
            _dogArray = newArray;
        }

        public IEnumerator<Dog> GetEnumerator()
        {
            foreach (var dog in _dogArray)
            {
                yield return dog;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
