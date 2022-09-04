using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.ISP.GoodExample.Interfaces
{
    public interface ITrain : IVehicle
    {
        void GoToNextStation();
    }
}
