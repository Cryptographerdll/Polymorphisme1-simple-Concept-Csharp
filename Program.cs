using System;

namespace Polymorphisme_Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            Directeur Dr1 = new Directeur("amine alami", new DateTime(2020, 05, 01), 15000);
           float salaire = Dr1.CalculateSalaire();

            Console.Write("le salaire annuel est : {0}", salaire);
        }
    }
}
