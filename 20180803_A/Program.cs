using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180803_A_TP
{
    class Program
    {
        static void Main(string[] args)
        { }
    }
    //classes
    public abstract class Animal
    {
        public void Marcher()
        { }
    }

    public abstract class Mammifere : Animal
    {}

    public class Oiseau : Animal
    {
        public bool PeutVoler { get; set; }
    }

    public class Chien : Mammifere
    {
        public void Aboyer()
        { }
    }

    public class Chat : Mammifere
    {
        public void Miauler()
        { }
    }

    public class Poule : Oiseau
    { }
}
