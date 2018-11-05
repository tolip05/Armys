using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryJava.Interfaces
{
   public interface IMission
    {
        string GetCodeName();
        string GetState();

        void CompleteMission();
    }
}
