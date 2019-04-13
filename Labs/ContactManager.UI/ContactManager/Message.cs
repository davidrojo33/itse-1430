/*
 * Lab3
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
    public class Message
    {
        public int Id { get; set; }

        public Message()
        {

        }

        public string Subject
        {
            get { return _subject ?? ""; }
            set { _subject = value ?? ""; }
        }

        private string _subject = "";

        public string Body
        {
            get { return _body ?? ""; }
            set { _body = value; }
        }

        private string _body = "";

        public string MessageContact
        {
            get { return _email ?? ""; }
            set { _email = value; }
        }

        private string _email = "";

        public IEnumerable<ValidationResult> Validate( ValidationContext validationContext )
        {
            var items = new List<ValidationResult>();

            if (String.IsNullOrEmpty(_body))
                items.Add(new ValidationResult("Name is required.", new[] { nameof(_body) }));

            if (String.IsNullOrEmpty(_subject))
                items.Add(new ValidationResult("Email is required.", new[] { nameof(_subject) }));

            return items;
        }

        bool IsValidEmail( string source )
        {
            try
            {
                new System.Net.Mail.MailAddress(source);
                return true;
            } catch
            { };

            return false;
        }
    }
}
