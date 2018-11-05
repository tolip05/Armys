using MilitaryJava.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryJava.Implementation
{
    public class SpyImpl : SoldierImpl, ISpy
    {
        private int codeName;
        public SpyImpl(int id, string firstName, string lastName,int codeName) 
            : base(id, firstName, lastName)
        {
            this.CodeName = codeName;
        }

        public int CodeName
        {
            get => codeName;
            private set
            {
                codeName = value;
            }
        }

        public int GetCodeNumber()
        {
            return this.CodeName;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nCode Number: {this.GetCodeNumber()}";
        }
    }
}
