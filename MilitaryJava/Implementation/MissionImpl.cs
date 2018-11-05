using MilitaryJava.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryJava.Implementation
{
    public class MissionImpl : IMission
    {
        private const string finished_Mission = "Finished";
        private const string missionInProgress = "inProgress";
        private string codeName;
        private string state;

        public MissionImpl(string codeName, string state)
        {
            this.CodeName = codeName;
            this.State = state;
        }

        public string CodeName
        {
            get => codeName;
            private set
            {
                codeName = value;
            }
        }
        public string State
        {
            get => state;
            private set
            {
                if (finished_Mission == value || missionInProgress == value)
                {
                    state = value;
                }
                
            }
        }

        public void CompleteMission()
        {
            this.State = finished_Mission;
        }

        public string GetCodeName()
        {
            return this.CodeName;
        }

        public string GetState()
        {
            return this.State;
        }
        public override string ToString()
        {
            return $"  Code Name: {this.GetCodeName()} State: {this.GetState()}";
        }
    }
}
