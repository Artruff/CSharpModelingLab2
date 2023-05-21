using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpModelingLab2.Classes
{
    class DumpTrackStatisticCreator : Interfaces.IStatiscticCreater
    {
        DumpTrackModel _dump;
        string _name;

        double _weightTotal, _waitingTotal, _loadingTotal,
            _ridingTotal, _shipmentTotal, _prevTime;
        int _loadCount, _ridingCount, _shipmentCount, _waitingCount;
        public DumpTrackStatisticCreator(string name, DumpTrackModel dump)
        {
            _dump = dump;
            _name = name;
            _weightTotal = _waitingTotal = _prevTime = _loadingTotal =
                _ridingTotal = _shipmentTotal = _loadCount =
                _ridingCount = _shipmentCount = _waitingCount = 0;

            _dump.Ride += LoadedOrShipmented;
            _dump.Shipment += Rided;
            _dump.Loading += Rided;
            _dump.Wait += Waitied;
        }
        public string[] GetStatistic()
        {
            string[] result = new string[6];

            result[0] = "Данные по самосвалу - " + _name;
            result[1] = "Перевезено всего: " + _weightTotal;
            result[2] = "Всего время на загрузку: " + _loadingTotal + ", за " + _loadCount + " раз, в среднем: " + _loadingTotal / _loadCount;
            result[3] = "Всего время на выгрузку: " + _shipmentTotal + ", за " + _shipmentCount + " раз, в среднем: " + _shipmentTotal / _shipmentCount;
            result[4] = "Всего время в пути: " + _ridingTotal + ", за " + _ridingCount + " раз, в среднем: " + _ridingTotal / _ridingCount;
            result[5] = "Всего время в очереди: " + _waitingTotal + ", за " + _waitingCount + " раз, в среднем: " + _waitingTotal / _waitingCount;

            return result;
        }

        private void LoadedOrShipmented(double time)
        {
            if(_dump.status == Interfaces.StatusCar.GoesToQuarry)
            {
                _loadingTotal += _prevTime;
                _loadCount++;
            }
            else
            {
                _shipmentTotal += _prevTime;
                _shipmentCount++;
                _weightTotal+=_dump.weight;
            }
            _prevTime = time;
        }
        private void Rided(double time)
        {
            _ridingTotal += _prevTime;
            _ridingCount++;
            _prevTime = time;
        }
        private void Waitied(double time)
        {
            _waitingTotal += _prevTime;
            _waitingCount++;
            _prevTime = time;
        }
    }
}
