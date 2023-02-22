using System;
using System.Reflection;

namespace CYKLY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int body = 0;
            Console.WriteLine("Je Slunce koulí žhavých plynů?");
            string spravnaodpoved = "ano";
            string odpoved = Console.ReadLine();
            if (odpoved.ToLower() == spravnaodpoved.ToLower())
            {
                Console.WriteLine("Správně! Předtím jsi měl {0} bodů a teď máš o jeden víc!",++body);

            }

            
        }
    }
}
