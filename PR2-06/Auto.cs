using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR2_06
{
    class Auto : ITransport
    {
        public void Drive()
        { Console.WriteLine("Машина едет по дороге"); }
    }
}
