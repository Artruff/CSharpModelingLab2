using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpModelingLab1.Classes
{
    class SmirnovCriterion
    {
        double[] _randomValue1;
        double[] _randomValue2;
        public SmirnovCriterion(double[] randomValue1, double[] randomValue2)
        {
            _randomValue1 = new double[randomValue1.Length];
            _randomValue2 = new double[randomValue2.Length];
            randomValue1.CopyTo(_randomValue1, 0);
            randomValue2.CopyTo(_randomValue2, 0);
        }
        public bool CheckingAgreement(Interfaces.IFunctionDensity F1, Interfaces.IFunctionDensity F2, double criterion)
        {
            return Agreement(F1, F2) < criterion;
        }
        public double Agreement(Interfaces.IFunctionDensity F1, Interfaces.IFunctionDensity F2)
        {
            double D = 0, Dm = 0, Dp = 0;

            //Проверяем гипотезу
            //Ищем максимальное отклонение
            for (int i = 0; i < _randomValue1.Length; i++)
                Dp = Math.Max(Dp, Math.Abs((Convert.ToDouble(i) / _randomValue1.Length) - F1.Density(_randomValue1[i])));
  
            for(int i = 0; i<_randomValue2.Length; i++)
                Dm = Math.Max(Dm, Math.Abs((Convert.ToDouble(i) / _randomValue2.Length) - F2.Density(_randomValue2[i])));
            
            D = Dp - Dm;

            //Вычисляем Статистику смирнова
            return D * Math.Sqrt((_randomValue1.Length*_randomValue2.Length)/(_randomValue1.Length + _randomValue2.Length));
        }
    }
}
