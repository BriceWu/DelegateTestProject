using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTestProject
{
    public class AnonymousDelgate:DelegateFather
    {
        public override bool DelegatFunction(int m)
        {
            DelegatMethod hander = delegate (int a) { return a > num; };
            return hander(m);
        }
    }
}
