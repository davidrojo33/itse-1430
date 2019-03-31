using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
    public interface IContactDatabase
    {
        Contacts Add( Contacts contact );

        void Delete( int id );

        Contacts Get( int id );

        IEnumerable<Contacts> GetAll();

        Contacts Update( int id, Contacts contact );
    }
}
