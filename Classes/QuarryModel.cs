using CSharpModelingLab2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpModelingLab2.Classes
{
    class QuarryModel : IPlaceModel
    {
        QuarryStatisticCreator _quarryStatisticCreator;
        public QuarryModel(QuarryStatisticCreator quarryStatisticCreator)
        {
            _quarryStatisticCreator = quarryStatisticCreator;
            _carList = new List<(ExcavatorModel excavator, IModelingCar car, double time)>();
        }
        List<(ExcavatorModel excavator, IModelingCar car, double time)> _carList = new List<(ExcavatorModel excavator, IModelingCar car, double time)>();
        public IStatiscticCreater statiscticCreater => throw new NotImplementedException();

        public event ModelAction NewAction;

        public string GetInfo()
        {
            throw new NotImplementedException();
        }

        public void TimeStep(double time)
        {
            for (int i = 0; i < _carList.Count; i++)
            {
                _carList[i] = (_carList[i].excavator, _carList[i].car, _carList[i].time - time);
                if(_carList[i].time<= 0 )
                {
                    if (_carList[i].car.status == StatusCar.GoesToExcavator)
                    {
                        _carList[i].excavator.AddCar(_carList[i].car);
                        _carList.RemoveAt(i--);
                    }
                    else
                    {
                        _carList[i] = (_carList[i].excavator, _carList[i].car, _carList[i].car.NextAction());
                        if(NewAction != null)
                            NewAction(_carList[i].time);
                    }
                }
            }
        }
        public void AddCar(ExcavatorModel excavator, IModelingCar car)
        {
            double time = car.NextAction();
            _carList.Add((excavator, car, time)); 
            if (NewAction != null)
                NewAction(time);
        }
    }
}
