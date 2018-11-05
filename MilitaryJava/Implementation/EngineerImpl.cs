using MilitaryJava.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryJava.Implementation
{
    public class EngineerImpl : SpecialistSoldierImpl, IEngineer
    {
        private ICollection<IRepair> repairs;
        public EngineerImpl(int id, string firstName, string lastName, decimal salary, string corps,ICollection<IRepair>repairs) 
            : base(id, firstName, lastName, salary, corps)
        {
            this.Repairs = repairs;
        }

        public ICollection<IRepair> Repairs
        {
            get => repairs;
            set
            {
                if (value != null)
                {
                    repairs = new List<IRepair>(value);
                    return;
                }
                repairs = new List<IRepair>();
            }
        }

        public override ICollection<IRepair> getRepairs()
        {
            return this.Repairs;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var repair in this.Repairs)
            {
                sb.Append(repair).Append("\n");
            }
            return base.ToString() + $"\nRepairs:\n" + sb.ToString();
        }
    }
}
