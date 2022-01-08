using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class TransitionProcess : AbstractDecorator
    {
        public TransitionProcess(DynamicSystem s) : base(s.NameSystem + " с переходным процессом", s)
        { }
    }
}
