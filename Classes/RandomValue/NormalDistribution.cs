using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpModelingLab1.Classes
{
    class NormalDistribution : Interfaces.IFunctionDensity
    {
        private double _expectation;
        private double _squarDeviation;
        public NormalDistribution(double expectation, double squarDeviation)
        {
            _expectation = expectation;
            _squarDeviation = squarDeviation;
        }

        public double Density(double x)
        {
            double arg = 1d / Math.Sqrt(2d * Math.PI * _squarDeviation),
                exp = Math.Exp((-Math.Pow(x - _expectation, 2)) / (2d * Math.Pow(_squarDeviation, 2)));
            return arg * exp;
        }
    }
}
