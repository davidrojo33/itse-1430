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
    public abstract class ContactDatabase : IContactDatabase
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
            if (index >= 0)
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
            foreach (var item in _items)
                yield return Clone(item);
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

        protected abstract Contact AddCore( Contact contact );

        protected abstract void DeleteCore( int id );

        protected virtual Contact FindByName( string name )
        {
            foreach (var contact in GetAllCore())
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

        protected abstract Contact GetCore( int id );

        protected abstract IEnumerable<Contact> GetAllCore();

        protected abstract Contact UpdateCore( int id, Contact newContact );
    }

}
