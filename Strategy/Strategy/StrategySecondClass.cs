using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class StrategySecondClass : IStrategy
    {
        public void Hello()
        {
            Console.WriteLine("Привет я Воторой класс приветствия");
        }
    }
}
