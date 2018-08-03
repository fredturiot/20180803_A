using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180803_C_poluymorphisme
{
    class Program
    {
        static void Main(string[] args)
        {
            var a1 = new A1();
            var a2 = new A2();

            var b = new B();
            var b1 = new B1();
            var b2 = new B2();
            var b3 = new B3();

            a1.Methode();
            a2.Methode();

            b.Methode();
            b1.Methode();
            b2.Methode();
            b3.Methode();

            Console.ReadKey();

            
        }

        public abstract class A
        {
            public abstract void Methode();
        }
        public class A1 : A
        {
            public override void Methode()
            {
                Console.WriteLine("A1");
            }
        }
        public class A2 : A { }//erreur car pas d'implementation de l abstract

        public class B
        {
            public virtual void Methode()
            { }

        }
        public class B1 :B
        {
            //ok car virtual
        }
        public class B2 : B
        {
            public override void Methode()
            {
                Console.WriteLine("B2");
            }

        }
        public class B3 : B
        {
            public override void Methode()//tapper public override void.. pour l'autocompletion
            {
                base.Methode();
                Console.WriteLine("B3");
            }
        }
    }
}
