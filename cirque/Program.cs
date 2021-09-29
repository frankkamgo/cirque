using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cirque
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Bonjour");
            Dresseur dr1 = new Dresseur("Frank");
            Dresseur dr2 = new Dresseur("Frank");
            Console.WriteLine(dr1.Equals(dr2));
            /*
            if(Console.WriteLine(dr1.Equals(dr2)))
            {

            }*/
            Console.WriteLine(dr1.infos());

            Console.ReadKey();
        }
    }
}
