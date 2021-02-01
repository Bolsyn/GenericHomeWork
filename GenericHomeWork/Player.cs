using System;
using System.Collections.Generic;
using System.Text;

namespace GenericHomeWork
{
    public class Player
    {
        public List<Karta> Hand { get; set; }
        Random rand = new Random();
        public Karta Output()
        {
            return Hand[rand.Next() % Hand.Count];
        }
    }
}
