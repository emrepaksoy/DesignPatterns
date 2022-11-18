﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceManager
{
    public class Tablet : IDevice
    {
        public int Id { get; set; }
        public string Name { get ; set ; }

        public IDevice Clone() => (IDevice)MemberwiseClone();

    }
}
