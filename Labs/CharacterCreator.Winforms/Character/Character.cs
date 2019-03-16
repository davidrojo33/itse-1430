﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character
{
    public class Character
    {

        public int Id { get; set; }

        public Character (string name)
        {
            Name = name;
        }

        public string Name
        {
            get { return _name ?? ""; }
            set { _name = value ?? ""; }
        }

        private string _name = "";

        public string Profession
        {
            get { return _profession ?? ""; }
            set { _profession = value; }
        }

        private string _profession = "";

        private string Race
        {
            get { return _race ?? ""; }
            set { _race = value; }
        }

        private string _race = "";

        private string Attributes
        {
            get { return _attributes ?? ""; }
            set { _attributes = value; }
        }

        private string _attributes = "";

        public override string ToString()
        {
            return Name;
        }

        public bool Validate ()
        {
            if (String.IsNullOrEmpty(Name))
                return false;

            return true;
        }
    }
}
