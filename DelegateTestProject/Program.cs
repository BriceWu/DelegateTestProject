using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            DelegateFather[] handers =
            {
                new Delegate(),
                new AnonymousDelgate(),
                new LambdaDelgate(),
                new FuncDelgate()
            };
            //逐个输出
            foreach(var hander in handers)
            {
                var result = hander.DelegatFunction(10);
                Console.WriteLine(result);
            }
            
            Console.ReadKey();
        }
    }
}
