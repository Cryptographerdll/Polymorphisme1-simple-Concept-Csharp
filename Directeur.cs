using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphisme_Part1
{
    class Directeur : Employee
    {
        private float TauxPrime;
        public Directeur(string nomComplet, DateTime dateRecrutement, float salaire) : base(nomComplet, dateRecrutement, salaire)
        {
            this.TauxPrime = 0.1F;
        }

        public override float CalculateSalaire() // Polymorphisme Done .
        {
            return (base.salaire * 12) + (base.salaire * this.TauxPrime);
        }
    }
}
