using MilitaryJava.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryJava.Implementation
{
    public class LieutenantGeneralImpl : PrivateImpl, ILieutenantGeneral
    {
        private ICollection<IPrivate> privates;
        public LieutenantGeneralImpl(int id, string firstName, string lastName, decimal salary,ICollection<IPrivate>privates) 
            : base(id, firstName, lastName, salary)
        {
            this.Privates = privates;
        }

        public ICollection<IPrivate> Privates
        {
            get => privates;
            private set
            {
                if (value != null)
                {
                    privates = new List<IPrivate>(value);
                    return;
                }
                privates = new List<IPrivate>();
            }
        }

        public ICollection<IPrivate> GetPrivate()
        {
            return this.Privates;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in this.GetPrivate())
            {
                sb.Append("  ").Append(item).Append("\n");
            }
            return base.ToString() + $"\nPrivates:\n" + sb.ToString();
        }
    }
}
