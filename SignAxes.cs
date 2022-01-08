using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class SignAxes : AbstractDecorator
    {
        public SignAxes(DynamicSystem s) : base(s.NameSystem + " с подписанными осями", s)
        { }
    }
}
