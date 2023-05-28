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
        public QuarryModel(string name)
        {
            _quarryStatisticCreator = new QuarryStatisticCreator(name, this);
            _carList = new List<(ExcavatorModel excavator, IModelingCar car, double time)>();
        }
        List<(ExcavatorModel excavator, IModelingCar car, double time)> _carList = new List<(ExcavatorModel excavator, IModelingCar car, double time)>();
        public IStatiscticCreater statiscticCreater => _quarryStatisticCreator;

        public event ModelAction NewAction;
        public event ModelAction GoBack;
        public event ModelAction Shipmenting;
        public event ModelAction Plain;
        public event ModelAdded CarArrived;

        public string[] GetInfo()
        {
            List<string> info = new List<string>(_quarryStatisticCreator.GetStatistic());
            info.Add("");

            foreach (var model in _carList)
            {
                info.AddRange(model.car.GetInfo());
                info.Add("");
            }

            return info.ToArray();
        }

        public void TimeStep(double time)
        {
            bool wasEvent = false;
            for (int i = 0; i < _carList.Count; i++)
            {
                _carList[i] = (_carList[i].excavator, _carList[i].car, _carList[i].time - time);
                if (_carList[i].time <= 0)
                {
                    if (_carList[i].car.status == StatusCar.GoesToExcavator)
                    {
                        _carList[i].excavator.AddCar(_carList[i].car);
                        _carList.RemoveAt(i--);
                    }
                    else
                    {
                        _carList[i] = (_carList[i].excavator, _carList[i].car, _carList[i].car.NextAction());
                        wasEvent = true;

                        if (NewAction != null)
                            NewAction(_carList[i].time);

                        if (_carList[i].car.status == StatusCar.Shipmenting)
                        {
                            if (Shipmenting != null)
                                Shipmenting(_carList[i].time);
                        }
                        else if (_carList[i].car.status == StatusCar.GoesToExcavator)
                            if (GoBack != null)
                                GoBack(_carList[i].time);
                    }
                }
            }

            if (!wasEvent)
                Plain(time);
        }
        public void AddCar(ExcavatorModel excavator, IModelingCar car)
        {
            CarArrived(car);
            double time = car.NextAction();
            _carList.Add((excavator, car, time)); 
            if (NewAction != null)
                NewAction(time);
        }
    }
}
