using CSharpModelingLab2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpModelingLab2.Classes
{
    class ExcavatorModel : IPlaceModel
    {
        QuarryModel _quarryModel;
        ExcavatorStatisticCreator _excavatorStatisticCreator;
        List<IModelingCar> _modelingCars;
        double _timeLoading;

        public event ModelAction NewAction;
        public event ModelAction Plain;

        public ExcavatorModel(ExcavatorStatisticCreator excavatorStatisticCreator, QuarryModel quarry)
        {
            _quarryModel = quarry;
            _modelingCars = new List<IModelingCar>();
            _excavatorStatisticCreator = excavatorStatisticCreator;
            _timeLoading = 0;
        }

        List<IModelingCar> modelingCars { get => _modelingCars; }
        public IStatiscticCreater statiscticCreater => _excavatorStatisticCreator;

        public string GetInfo()
        {
            throw new NotImplementedException();
        }

        public void TimeStep(double time)
        {
            _timeLoading -= time;
            if (_timeLoading <= 0)
            {
                if (_modelingCars.Count != 0)
                {
                    IModelingCar car = _modelingCars.First();
                    _modelingCars.Remove(car);
                    _quarryModel.AddCar(this, car);
                    if (_modelingCars.Count != 0)
                    {
                        double timeAction = _modelingCars.First().NextAction();
                        NewAction(timeAction);
                    }
                }
                else if(Plain!=null)
                    Plain(time);
            }
        }
        public void AddCar(IModelingCar car)
        {
            _modelingCars.Add(car);
            if (_modelingCars.Count == 1)
            {
                _timeLoading = car.NextAction();
                NewAction(_timeLoading);
            }
        }
    }
}
