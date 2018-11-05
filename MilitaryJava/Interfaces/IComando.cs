using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryJava.Interfaces
{
   public interface IComando
    {
        ICollection<IMission> misions();
    }
}
