using MilitaryJava.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryJava.Implementation
{
    public class PrivateImpl : SoldierImpl,IPrivate
    {
        private decimal salary;
        public PrivateImpl(int id, string firstName, string lastName,decimal salary) 
            : base(id, firstName, lastName)
        {
            this.Salary = salary;
        }

        public decimal Salary
        {
            get => salary;
            private set
            {
                salary = value;
            }
        }

        public decimal GetSalary()
        {
            return this.Salary;
        }
        public override string ToString()
        {
            return base.ToString() + $" Salary: {this.GetSalary()}";
        }
    }

}
