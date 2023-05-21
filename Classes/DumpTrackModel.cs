using CSharpModelingLab2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpModelingLab2.Classes
{
    class DumpTrackModel : IModelingCar
    {
        StatusCar _status;
        DumpTrackStatisticCreator _dumpTrackStatisticCreator;
        double _timeGoToExcavator, _timeGoToQuarry, _lyambdaLoading, _lyambdaShipment, _weight;
        Random _rand;

        public DumpTrackModel(double weight, double timeGoToExcavator, double timeGoToQuarry, double lyambdaLoading, double lyambdaShipment, string name)
        {
            _weight = weight;
            _timeGoToExcavator = timeGoToExcavator;
            _timeGoToQuarry = timeGoToQuarry;
            _lyambdaLoading = lyambdaLoading;
            _lyambdaShipment = lyambdaShipment;
            _rand = new Random();
            _dumpTrackStatisticCreator = new DumpTrackStatisticCreator(name, this);
            _status = StatusCar.GoesToExcavator;
        }
        public IStatiscticCreater statiscticCreater => _dumpTrackStatisticCreator;

        public StatusCar status => _status;

        public event ModelAction Loading;
        public event ModelAction Shipment;
        public event ModelAction Ride;
        public event ModelAction Wait;

        public double weight { get => weight; }
        public string GetInfo()
        {
            throw new NotImplementedException();
        }

        public double NextAction()
        {
            double time = 0;
            switch (status)
            {
                case StatusCar.Loading:
                    _status = StatusCar.GoesToQuarry;
                    time = _timeGoToQuarry;
                    if(Ride != null)
                        Ride(time);
                    break;
                case StatusCar.GoesToQuarry:
                    _status = StatusCar.Shipmenting;
                    time = GetExpRandValue(_lyambdaShipment);
                    if(Shipment != null)
                        Shipment(time);
                    break;
                case StatusCar.Shipmenting:
                    _status = StatusCar.GoesToExcavator;
                    time = _timeGoToExcavator;
                    if(Ride != null)
                        Ride(time);
                    break;
                case StatusCar.GoesToExcavator:
                    _status = StatusCar.Loading;
                    time = GetExpRandValue(_lyambdaLoading);
                    if (Loading != null)
                        Loading(time);
                    break;
            }
            return time;
        }
        private double GetExpRandValue(double lyambda)
        {
            CSharpModelingLab1.Classes.FunctionDistribution expDistribution = new CSharpModelingLab1.Classes.FunctionDistribution(
                delegate (double x)
                {
                    return lyambda * Math.Exp(-lyambda * x);
                },
                delegate (double x)
                {
                    return 1 - Math.Exp(-lyambda * x);
                });
            
            return expDistribution.Density(_rand.NextDouble());
        }

        public void Waiting(double time)
        {
            Wait(time);
        }
    }
}
