using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpModelingLab1.Classes
{
    class RandomValueGenerator
    {
        Interfaces.IFunctionDensity _density;
        double _leftBorder, _rightBorder;
        Random _random;
        public double leftBorder
        {
            get => _leftBorder;
        }
        public double rightBorder
        {
            get => _rightBorder;
        }
        public RandomValueGenerator(Interfaces.IFunctionDensity density, double leftBorder, double rightBorder)
        {
            _random = new Random();
            _density = density;
            _leftBorder = leftBorder;
            _rightBorder = rightBorder;
        }
        public double Next()
        {
            double x;
            if (_leftBorder == 0 && _rightBorder == 1)
                x = _random.NextDouble();
            else
                x = _random.NextDouble()*_random.Next((int)_leftBorder, (int)_rightBorder);
            return _density.Density(x);
        }
    }
}
