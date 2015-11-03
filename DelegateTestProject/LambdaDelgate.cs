using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTestProject
{
    public class LambdaDelgate:DelegateFather
    {
        public override bool DelegatFunction(int m)
        {
            DelegatMethod del = a => a > num;
            return del(m);
        }
    }
}
