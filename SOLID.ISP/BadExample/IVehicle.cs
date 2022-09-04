using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.ISP.BadExample
{
    public interface IVehicle
    {
        void Run();
        void Fly();
        void OpenDoor();
        void OpenRoof();
        void GoToNextStation();
    }
}
