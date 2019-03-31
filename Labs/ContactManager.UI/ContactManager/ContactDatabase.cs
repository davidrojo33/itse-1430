using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
    public class ContactDatabase : IContactDatabase
    {
        public Contacts Add( Contacts contact )
        {
            if (contact == null)
            throw new ArgumentException(nameof(contact));

            ObjectValidator.Validate(contact);

            var existing = FindByName(contact.Name);
            if (existing != null)
                throw new Exception("Contact must be unique.");

            return AddCore(contact);
        }

        public void Delete( int id )
        {
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), "Id must be > 0.");

            DeleteCore(id);
        }

        public Contacts Get( int id )
        {
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), "Id must be > 0");

            return GetCore(id);
        }

        public IEnumerable<Contacts> GetAll()
        {
            return GetAllCore();
        }

        public Contacts Update( int id, Contacts contact )
        {
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), "Id must be > 0.");
            if (contact == null)
                throw new ArgumentNullException(nameof(contact));

            ObjectValidator.Validate(contact);

            var existing = GetCore(id);
            if (existing != null)
                throw new Exception("Contact does not exit.");

            var sameName = FindByName(contact.Name);
            if (sameName != null && sameName.Id != id)
                throw new Exception("Contact must be unique.");

            return UpdateCore(id, contact);
        }

        protected abstract Contacts AddCore( Contacts contact );

        protected abstract void DeleteCore( int id );

        protected virtual Contacts FindByName(string name)
        {
            foreach ( var contact in GetAllCore())
            {
                if (String.Compare(contact.Name, name, true) == 0)
                    return contact;
            };
            return null;
        }

        protected abstract Contacts GetCore( int id );

        protected abstract IEnumerable<Contacts> GetAllCore();

        protected abstract Contacts UpdateCore( int id, Contacts newContact );
    }
}
