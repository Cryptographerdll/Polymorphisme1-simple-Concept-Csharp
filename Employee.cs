using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphisme_Part1
{
    class Employee
    {
        public string nomComplet;
        public DateTime dateRecrutement;
        public float salaire;

        public Employee(string nomComplet, DateTime dateRecrutement, float salaire)
        {
            this.nomComplet = nomComplet;
            this.dateRecrutement = dateRecrutement;
            this.salaire = salaire;
        }

        public virtual float CalculateSalaire()
        {
            return this.salaire * 12;
        }
    }
}
