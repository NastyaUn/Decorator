using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    abstract class DynamicSystem
    {
        public DynamicSystem(string syst)
        {
            this.NameSystem = syst;
        }
        public string NameSystem { get; protected set; }
    }
}
