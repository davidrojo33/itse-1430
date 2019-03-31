using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
    class MemoryContactDatabase : ContactDatabase
    {

        protected override Contacts AddCore( Contacts contact )
        {
            contact.Id = ++_nextId;
            _items.Add(Clone(contact));

            return contact;
        }

        protected override void DeleteCore( int id )
        {
            var index = GetIndex(id);
            if (index >= 0)
                _items.RemoveAt(index);
        }

        protected override Contacts GetCore( int id )
        {
            var index = GetIndex(id);
            if (index >= 0)
                return Clone(_items[index]);

            return null;
        }

        protected override IEnumerable<Contacts> GetAllCore()
        {
            foreach (var item in _items)
                yield return Clone(item);
        }

        protected override Contacts UpdateCore( int id, Contacts contact )
        {
            var index = GetIndex(id);

            contact.Id = id;
            var existing = _items[index];
            Clone(existing, contact);

            return contact;
        }

        private Contacts Clone(Contacts contact)
        {
            var newContact = new Contacts();
            Clone(newContact, contact);

            return newContact;
        }

        private void Clone(Contacts target, Contacts source)
        {
            target.Id = source.Id;
            target.Name = source.Name;
            target.Email = source.Email;
        }

        private int GetIndex(int id)
        {
            for (var index = 0; index < _items.Count; ++index)
                return index;

            return -1;
        }
    }
}
