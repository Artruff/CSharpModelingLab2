using CSharpModelingLab2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpModelingLab2.Classes
{
    class WorldModel : IPlaceModel
    {
        IStatiscticCreater _statiscticCreater;
        List<IPlaceModel> _modelingPlaces;
        List<double> _timeLaps = new List<double>();
        double _globalTime = 0;

        public event ModelAction NewAction;

        public WorldModel(WorldStatisticCreator statiscticCreater)
        {
            _statiscticCreater = statiscticCreater;
            _modelingPlaces = new List<IPlaceModel>();
        }
        public IStatiscticCreater statiscticCreater => _statiscticCreater;
        public void Tick()
        {
            if (_timeLaps.Count == 0)
                return;

            double time = _timeLaps.FirstOrDefault();

            TimeStep(time);
        }
        public double globalTime { get => _globalTime; }
        public string GetInfo()
        {
            throw new NotImplementedException();
        }

        public void TimeStep(double time)
        {
            _globalTime += time;
            for (int i = 0; i < _timeLaps.Count; i++)
            {
                _timeLaps[i] -= time;
                if (_timeLaps[i] == 0)
                    _timeLaps.RemoveAt(i--);
            }

            for (int i = 0; i < _modelingPlaces.Count; i++)
                _modelingPlaces[i].TimeStep(time);
        }
        public void AddPlace(IPlaceModel place)
        {
            _modelingPlaces.Add(place);
            place.NewAction += AddNewTime;
        }
        private void AddNewTime(double time)
        {
            _timeLaps.Add(time);
            _timeLaps.Sort();
            if(NewAction != null)
            NewAction(time);
        }
    }
}
