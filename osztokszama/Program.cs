using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osztokszama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Írj be egy számot!");
            int szam = int.Parse(Console.ReadLine());
            
            int osztok = 0;
            for (int i = 1; i <= szam; i++)
                if (szam % i == 0)
                    osztok++;

            Console.WriteLine(osztok + "db osztója van!");

            Console.ReadKey();
        }
    }
}
