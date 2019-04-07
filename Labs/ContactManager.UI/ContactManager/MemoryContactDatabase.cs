/*
 * Lab3
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace contactmanager
//{
//    public class memorycontactdatabase : contactdatabase
//    {

//        protected override contact addcore( contact contact )
//        {
//            contact.id = ++_nextid;
//            _items.add(clone(contact));

//            return contact;
//        }

//        protected override void deletecore( int id )
//        {
//            var index = getindex(id);
//            if (index >= 0)
//                _items.removeat(index);
//        }

//        protected override contact getcore( int id )
//        {
//            var index = getindex(id);
//            if (index >= 0)
//                return clone(_items[index]);

//            return null;
//        }

//        protected override ienumerable<contact> getallcore()
//        {
//            foreach (var item in _items)
//                yield return clone(item);
//        }

//        protected override contact updatecore( int id, contact contact )
//        {
//            var index = getindex(id);

//            contact.id = id;
//            var existing = _items[index];
//            clone(existing, contact);

//            return contact;
//        }

//        private contact clone( contact contact )
//        {
//            var newcontact = new contact();
//            clone(newcontact, contact);

//            return newcontact;
//        }

//        private void clone( contact target, contact source )
//        {
//            target.id = source.id;
//            target.name = source.name;
//            target.email = source.email;
//        }

//        private int getindex( int id )
//        {
//            for (var index = 0; index < _items.count; ++index)
//                return index;

//            return -1;
//        }

//        private readonly list<contact> _items = new list<contact>();

//        private int _nextid = 0;
//    }
//}
