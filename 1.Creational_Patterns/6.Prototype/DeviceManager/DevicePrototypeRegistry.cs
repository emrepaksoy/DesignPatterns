using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceManager
{
    public class DevicePrototypeRegistry
    {
        private readonly List<IDevice> _items = new List<IDevice>();

        public void Add(IDevice device) => _items.Add(device);

        public IDevice GetCopyById(int id)
        {
            var item = _items.SingleOrDefault(x => x.Id == id);
            if (item != null)
                return item.Clone();
            else
                throw new System.Exception("Provided device id was not found");
        }
    }
}
