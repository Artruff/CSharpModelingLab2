using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpModelingLab2.Classes
{
    class WorldStatisticCreator : Interfaces.IStatiscticCreater
    {
        WorldModel _world;
        string _name;
        float _countAction;

        public string name => _name;

        public WorldStatisticCreator(string name, WorldModel world)
        {
            _name = name;
            _world = world;
            _countAction = 0;
            _world.NewAction += Action;
        }
        public string[] GetStatistic()
        {
            string[] result = new string[4];

            result[0] = "Данные по миру - " + _name;
            result[1] = "Всего событий в модели: " + _countAction;
            result[2] = "Всего прошло времени: " + _world.globalTime;
            result[3] = "Среднее время между событиями:" + _countAction/_world.globalTime;

            return result;
        }
        public void Action(double time)
        {
            _countAction++;
        }
    }
}
