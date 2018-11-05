using MilitaryJava.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryJava.Implementation
{
    public class RepairImpl : IRepair
    {
        private string partName;
        private int hours;

        public RepairImpl(string partName, int hours)
        {
            this.PartName = partName;
            this.Hours = hours;
        }

        public string PartName
        {
            get => partName;
            private set
            {
                partName = value;
            }
        }
        public int Hours
        {
            get => hours;
            private set
            {
                hours = value;
            }
        }

        public int GetHours()
        {
            return this.Hours;
        }

        public string GetPartName()
        {
            return this.PartName;
        }
        public override string ToString()
        {
            return $"  Part Name: {this.GetPartName()} Hours Worked: {this.GetHours()}";
        }
    }
}
