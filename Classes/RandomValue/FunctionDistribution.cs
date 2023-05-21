using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpModelingLab1.Classes
{
    class FunctionDistribution : Interfaces.IFunctionDistribution, Interfaces.IFunctionDensity
    {
        private funcRandomVariables _Density;
        private funcRandomVariables _Distribution;
        public FunctionDistribution(funcRandomVariables Density, funcRandomVariables Distribution = null)
        {
            _Density = (funcRandomVariables)Density.Clone();
            if(Distribution !=null)
                _Distribution = (funcRandomVariables)Distribution.Clone();
        }
        public double Density(double x)
        {
            return _Density(x);
        }

        public double Distribution(double x)
        {
            return _Distribution(x);
        }
    }
}
