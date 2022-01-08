using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    abstract class AbstractDecorator : DynamicSystem 
    {
        protected DynamicSystem systemm;
        public AbstractDecorator(string n, DynamicSystem s) : base(n)
        {
            this.systemm = s;
        }
    }
}
