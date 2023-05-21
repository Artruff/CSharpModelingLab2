using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpModelingLab2.Interfaces
{
    interface IPlaceModel : IModelingObject
    {
        event ModelAction NewAction;
        void TimeStep(double time);
    }
}
