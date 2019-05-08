using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloMrSun;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (Ice.Communicator communicator = Ice.Util.initialize(ref args))
                {
                    var obj = communicator.stringToProxy("Manufacturer:default -h localhost -p 10000");
                    var client = ManufacturerPrxHelper.checkedCast(obj);
                    if (client == null)
                    {
                        throw new ApplicationException("Invalid proxy");
                    }

                    client.SendMaterials(new List<string>()
                    {
                        "Iron",
                        "Gold",
                        "Silver"
                    });
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
