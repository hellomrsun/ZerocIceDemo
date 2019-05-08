using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (Ice.Communicator communicator = Ice.Util.initialize(ref args))
                {
                    var adapter =
                        communicator.createObjectAdapterWithEndpoints("ManufacturerServer", "default -h localhost -p 10000");
                    adapter.add(new ManufacturerI(), Ice.Util.stringToIdentity("Manufacturer"));
                    adapter.activate();
                    communicator.waitForShutdown();
                }
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e);
            }
            Console.Read();
        }
    }
}
