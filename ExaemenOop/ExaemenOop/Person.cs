using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaemenOop
{
    internal class Person
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime YearOfBirth { get; set; }
        public int Age
        {
            get
            {
                return DateTime.Now.Year - YearOfBirth.Year;
            }
        }
    }
}
