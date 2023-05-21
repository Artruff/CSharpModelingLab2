using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpModelingLab2.Interfaces
{
    interface IModelingCar : IModelingObject
    {
        StatusCar status { get; }
        event ModelAction Loading;
        event ModelAction Shipment;
        event ModelAction Ride;
        event ModelAction Wait;
        double NextAction();
        void Waiting(double time);
    }
}
