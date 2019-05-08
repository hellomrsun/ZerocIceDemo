using HelloMrSun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ice;
using IceInternal;

namespace Server
{
    public class ManufacturerI : ManufacturerDisp_
    {
        public override bool SendMaterials(List<string> materials, Current current = null)
        {
            Console.WriteLine("Manufacturer server receives materials:");
            materials.ForEach(x => Console.WriteLine("-" + x));
            return true;
        }
    }
}
