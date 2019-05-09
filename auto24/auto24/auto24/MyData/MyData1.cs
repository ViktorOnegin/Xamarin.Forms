using System;
using System.Collections.Generic;
using System.Text;
using auto24.Models;

namespace auto24.MyData
{
    class MyData1
    {
        public List<Cars> Cars = new List<Cars>()
        {
            new Cars()
            {
                tootja = "audi",
                aasta = 2019,
                hind = 210000,
                mudel = "R8"
            }
        };
    }
}
