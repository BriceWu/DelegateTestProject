using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTestProject
{
    public class FuncDelgate:DelegateFather
    {
        public override bool DelegatFunction(int m)
        {
            Func<int, bool> hander = a => a > num;
            return hander(m);
        }
    }
}
