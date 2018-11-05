using MilitaryJava.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryJava.Implementation
{
    public abstract class SoldierImpl : ISoldier
    {
        private int id;
        private string firstName;
        private string LastName;

        protected SoldierImpl(int id, string firstName, string lastName)
        {
            this.id = id;
            this.firstName = firstName;
            this.LastName = lastName;
        }

        public string GetFirstName()
        {
            return this.firstName;
        }

        public int GetId()
        {
            return this.id;
        }

        public string GetLastName()
        {
            return this.LastName;
        }
        public override string ToString()
        {
            return $"Name: {this.GetFirstName()} {this.GetLastName()} Id: {this.GetId()}";
        }
    }
}
