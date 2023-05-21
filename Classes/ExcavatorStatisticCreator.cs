using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpModelingLab2.Classes
{
    class ExcavatorStatisticCreator : Interfaces.IStatiscticCreater
    {
        string _name;
        ExcavatorModel _excavator;
        double _plainExcTotal, _plainCarTotal, _loadTimeTotal;
        int _carCount, _loadCount;
        List<(Interfaces.IModelingCar car, double time)> _carsInQueue;

        public string name => _name;

        public ExcavatorStatisticCreator(string name, ExcavatorModel excavator)
        {
            _name = name;
            _excavator = excavator;
            _carsInQueue = new List<(Interfaces.IModelingCar car, double time)>();
            _plainExcTotal = _plainCarTotal = _loadTimeTotal =
                _carCount = _loadCount = 0;
            _excavator.Plain += Plain;
            _excavator.NewAction += Loaded;
            _excavator.CarArrived += CarArriver;
        }
        public string[] GetStatistic()
        {
            string[] result = new string[5];

            result[0] = "Данные по эксковатору - " + _name;
            result[1] = "Принято машин всего: " + _carCount;
            result[2] = "Всего время на загрузку: " + _loadTimeTotal + ", в среднем: " + _loadTimeTotal / _loadCount;
            result[3] = "Всего время простоя машин: " + _plainCarTotal + ", в среднем: " + _plainCarTotal / _carCount;
            result[4] = "Всего время простоя эксковатора: " + _plainExcTotal;

            return result;
        }

        private void Plain(double time)
        {
            _plainExcTotal += time;
        }
        private void Loaded(double time)
        {
            var carAndTime = _carsInQueue.First();
            _plainCarTotal += carAndTime.time;
            _loadTimeTotal += time;
            _loadCount++;

            _carsInQueue.Remove(carAndTime);

            for(int i=0; i<_carsInQueue.Count; i++)
                _carsInQueue[i] = (_carsInQueue[i].car, _carsInQueue[i].time+time);
        }
        private void CarArriver(Interfaces.IModelingCar car)
        {
            _carCount++;
            _carsInQueue.Add((car, 0));
        }
    }
}
