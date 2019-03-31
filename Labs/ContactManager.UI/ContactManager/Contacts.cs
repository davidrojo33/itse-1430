using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
    public class Contacts
    {
        public int Id { get; set; }

        public Contacts()
        {

        }

        public string Name
        {
            get { return _name ?? ""; }
            set { _name = value ?? ""; }
        }

        private string _name = "";

        public string Email
        {
            get { return _email ?? ""; }
            set { _email = value; }
        }

        private string _email = "";

        public override string ToString()
        {
            return Name;
        }

        public IEnumerable<VvalidationResult> Validate( ValidationContext validationContext )
        {
            var items = new List<ValidationResult>();
        }

    }
}
