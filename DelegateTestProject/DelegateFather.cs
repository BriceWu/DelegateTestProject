using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTestProject
{
    public abstract class DelegateFather
    {
        public const int num = 100;
        public delegate bool DelegatMethod(int a);
        public abstract bool DelegatFunction(int a);
    }
}
