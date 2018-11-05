using MilitaryJava.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryJava.Implementation
{
    public abstract class SpecialistSoldierImpl : PrivateImpl, ISpecialistSoldier
    {
        private const string airforces = "Airforces";
        private const string marines = "Marines";

        private string corps;

        public SpecialistSoldierImpl(int id, string firstName, string lastName, decimal salary,string corps) 
            : base(id, firstName, lastName, salary)
        {
            this.Corps = corps;
        }

        public string Corps
        {
            get => corps;
            set
            {
                if (marines == value || airforces == value)
                {
                    corps = value;
                }
                
            }
        }

        public string GetCorps()
        {
            return this.corps;
        }
        public override string ToString()
        {
            return base.ToString() + $"\nCorps: {this.GetCorps()}";
        }


        public abstract ICollection<IRepair> getRepairs();
    }
}
