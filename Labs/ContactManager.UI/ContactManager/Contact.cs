using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
    public class Contact : IValidatableObject
    {
        public int Id { get; set; }

        public Contact()
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

        public IEnumerable<ValidationResult> Validate( ValidationContext validationContext )
        {
            var items = new List<ValidationResult>();

            if (String.IsNullOrEmpty(Name))
                items.Add(new ValidationResult("Name is required.", new[] { nameof(Name) }));

            if (String.IsNullOrEmpty(Email))
                items.Add(new ValidationResult("Email is required.", new[] { nameof(Email) }));

            return items;
        }

        public interface IValidatableObject
        {

        }
    }
}
