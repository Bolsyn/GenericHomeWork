using System;
using System.Collections.Generic;
using System.Text;

namespace GenericHomeWork
{
    public class Karta
    {
        public Suit Suits { get; set; }
        public TypeOfCard Type { get; set; }
        public static bool operator >=(Karta a, Karta b) 
        {
            return (a.Suits >= b.Suits);
        }
        public static bool operator <=(Karta a, Karta b)
        {
            return (a.Suits <= b.Suits);
        }
    }
}
