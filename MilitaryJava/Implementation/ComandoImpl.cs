using MilitaryJava.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MilitaryJava.Implementation
{
    public class ComandoImpl : SpecialistSoldierImpl, IComando
    {
        private ICollection<IMission> misiions;
        public ComandoImpl(int id, string firstName, string lastName, decimal salary, string corps,ICollection<IMission>missions)
            : base(id, firstName, lastName, salary, corps)
        {
            this.Misiions = missions;
        }

        public ICollection<IMission> Misiions
        {
            get => misiions;
            private set
            {
                if (value != null)
                {
                    misiions = new List<IMission>(value);
                    return;
                }
                misiions = new List<IMission>();
            }
        }

        public override ICollection<IRepair> getRepairs()
        {
            return null;
        }

        public ICollection<IMission> misions()
        {
            return this.Misiions;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in this.misiions)
            {
                sb.Append(item).Append("\n");
            }
            return base.ToString() + $"\nMissions:{(this.Misiions.Count == 0? "":"\n")}" + sb.ToString();
            
        }
    }
}
