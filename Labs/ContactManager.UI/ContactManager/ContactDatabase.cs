/*
 * Lab3
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
    public class ContactDatabase : IContactDatabase
    {
        public Contact Add( Contact contact )
        {
            contact.Id = ++_nextid;
            _items.Add(Clone(contact));

            return contact;
        }

        public void Delete( int id )
        {
            var index = getindex(id);
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), "Id must be > 0.");
            _items.RemoveAt(index);
        }

        public Contact Get( int id )
        {
            var index = getindex(id);
            if (index >= 0)
            return Clone(_items[index]);

            return null;
        }

        public IEnumerable<Contact> GetAll()
        {
            var temp = new List<Contact>();
            foreach (var contact in _items)
                temp.Add(Clone(contact));

            return temp.ToArray();
        }

        public Contact Update( int id, Contact contact )
        {
            var index = getindex(id);

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

        protected virtual Contact FindByName( string name )
        {
            foreach (var contact in GetAll())
            {
                if (String.Compare(contact.Name, name, true) == 0)
                    return contact;
            };
            return null;
        }

        private void Clone( Contact target, Contact source )
        {
            target.Id = source.Id;
            target.Name = source.Name;
            target.Email = source.Email;
        }

        private int getindex( int id )
        {
            for (var index = 0; index < _items.Count; ++index)
                return index;

            return -1;
        }

        private readonly List<Contact> _items = new List<Contact>();

        private int _nextid = 0;
    }

}
