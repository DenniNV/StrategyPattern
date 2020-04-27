using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class HelloClass
    {
        private IStrategy _strategy;
        public HelloClass(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public void Execute()
        {
            _strategy.Hello();
        }

    }
}
