using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpModelingLab2.Classes
{
    class QuarryStatisticCreator : Interfaces.IStatiscticCreater
    {
        string _name;
        QuarryModel _quarry;
        double _plainQuaTotal, _uploadTimeTotal;
        int _carCount, _uploadCount;

        public string name => _name;

        public QuarryStatisticCreator(string name, QuarryModel quarry)
        {
            _name = name;
            _quarry = quarry;
            _plainQuaTotal = _uploadTimeTotal =
                _carCount = _uploadCount = 0;
            _quarry.Plain += Plain;
            _quarry.Shipmenting += Uploaded;
            _quarry.CarArrived += CarArriver;
        }
        public string[] GetStatistic()
        {
            string[] result = new string[4];

            result[0] = "Данные по карьеру - " + _name;
            result[1] = "Принято машин всего: " + _carCount;
            result[2] = "Всего время на загрузку: " + _uploadTimeTotal + ", в среднем: " + _uploadTimeTotal / _uploadCount;
            result[3] = "Всего время простоя карьера: " + _plainQuaTotal;

            return result;
        }

        private void Plain(double time)
        {
            _plainQuaTotal += time;
        }
        private void Uploaded(double time)
        {
            _uploadTimeTotal += time;
            _uploadCount++;
        }
        private void CarArriver(Interfaces.IModelingCar car)
        {
            _carCount++;
        }
    }
}
