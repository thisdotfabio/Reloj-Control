using System;
using System.Collections;
using System.Collections.Generic;

namespace Reloj_Control
{
    class ButtonsCollection : ICollection<ButtonSetting>
    {
        private List<ButtonSetting> _list;

        private static ButtonsCollection _items;
        public static ButtonsCollection Items
        {
            get
            {
                if (_items == null)
                    _items = new ButtonsCollection();

                return _items;
            }
        }

        protected ButtonsCollection()
        {
            _list = new List<ButtonSetting>();
        }

        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(ButtonSetting item)
        {
            _list.Add(item);
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(ButtonSetting item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(ButtonSetting[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<ButtonSetting> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool Remove(ButtonSetting item)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
