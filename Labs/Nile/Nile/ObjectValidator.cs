/*
 * David Rojo
 * 4/28/19
 * ITSE 1430
 */
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nile
{
    public static class ObjectValidator
    {

        public static void Validate( IValidatableObject value )
        {
            Validator.ValidateObject(value, new ValidationContext(value), true);
        }

    }
}
