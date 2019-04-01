using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
    public class MemoryContactDatabase : ContactDatabase
    {

        protected override Contact AddCore( Contact contact )
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

        protected override Contact GetCore( int id )
        {
            var index = GetIndex(id);
            if (index >= 0)
                return Clone(_items[index]);

            return null;
        }

        protected override IEnumerable<Contact> GetAllCore()
        {
            foreach (var item in _items)
                yield return Clone(item);
        }

        protected override Contact UpdateCore( int id, Contact contact )
        {
            var index = GetIndex(id);

            contact.Id = id;
            var existing = _items[index];
            Clone(existing, contact);

            return contact;
        }

        private Contact Clone( Contact contact )
        {
            var newContact = new Contact();
            Clone(newContact, contact);

            return newContact;
        }

        private void Clone( Contact target, Contact source )
        {
            target.Id = source.Id;
            target.Name = source.Name;
            target.Email = source.Email;
        }

        private int GetIndex( int id )
        {
            for (var index = 0; index < _items.Count; ++index)
                return index;

            return -1;
        }

        private readonly List<Contact> _items = new List<Contact>();

        private int _nextId = 0;
    }
}
