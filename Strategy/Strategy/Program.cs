using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            StrategyFirstClass strategyFirstClass = new StrategyFirstClass();
            StrategySecondClass strategySecondClass = new StrategySecondClass();
            HelloClass hello = new HelloClass(strategyFirstClass);
            hello.Execute();
            hello = new HelloClass(strategySecondClass);
            hello.Execute();
            Console.ReadLine();
        }
    }
}
