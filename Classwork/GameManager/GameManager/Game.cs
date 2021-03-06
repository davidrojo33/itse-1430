﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManager
{
    /// <summary>Represents a game.</summary>
    public class Game : IValidatableObject
    {
        public int Id { get; set; }

        /// <summary>Name of the game.</summary>
        [Required(AllowEmptyStrings = false)]
        public string Name
        {
            //get { return _name ?? ""; }
            get => _name ?? "";
            //set { _name = value ?? ""; }
            set => _name = value ?? "";
        }

        private string _name = "";

        /// <summary>Publisher of the game.</summary>
        public string Description
        {
            get => _description ?? "";
            set => _description = value;
        }

        private string _description = "";

        //Calculated property
        /*public bool IsCoolGame
        {
            get { return Price < 59.99M; }
        }*/
        public bool IsCoolGame => Price < 59.99M;

        //private bool IsCoolGame2 = true;

        //Setter only
        //public string Password
        //{
        //    set { }
        //}

        //Auto property

        [RangeAttribute(0, Double.MaxValue, ErrorMessage = "Price must be >= 0." )]
        public decimal Price { get; set; }

        //public decimal Price
        //{
        //    get { return _price; }
        //    set { _price = value; }
        //}
        //private decimal _price;

        public bool Owned { get; set; } = true;

        public bool Completed { get; set; }

        //Mixed accessibility
        public double Rate
        {
            get;
            internal set;
        }

        public void Foo()
        {
            //NOT DETERMINISTIC - should have been a method
            var now = DateTime.Now;
        }

        //public override string ToString()
        //{
        //    return Name;
        //}        
        public override string ToString() => Name;

        public IEnumerable<ValidationResult> Validate( ValidationContext validationContext )
        {
            var items = new List<ValidationResult>();

            if (Price > 1000)
                items.Add(new ValidationResult("Price too expensive.", new[] { nameof(Price) }));

            ////Name is required
            //if (String.IsNullOrEmpty(Name))
            //    items.Add(new ValidationResult("Name is required.", new[] { nameof(Name) }));

            //Price >= 0
            //if (Price < 0)
            //    items.Add(new ValidationResult("Price must be >= 0.", new[] { nameof(Price) }));

            return items;
        }
    }
}



//Can init the data as well
//public string[] Genres { get; set; }

// Don't use array properties because they require cloning
// and are inefficient
//public string[] Genres
//{
//    get 
//    {
//        var temp = new string[_genres.Length];
//        Array.Copy(_genres, temp, _genres.Length);
//        return temp;
//    }
//}
//private string[] _genres;

//public string[] genres = new string[10];
//private decimal realPrice = Price;

/// <summary>Validates the object.</summary>
/// <returns>true if valid or false otherwise.</returns>