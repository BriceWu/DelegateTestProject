using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTestProject
{
    public class Delegate:DelegateFather
    {
        public override bool DelegatFunction(int a)
        {
            DelegatMethod hander = CompareMethod;

            return hander(a);
        }

        public bool CompareMethod(int a)
        {
            return a > num;
        }
    }
}
