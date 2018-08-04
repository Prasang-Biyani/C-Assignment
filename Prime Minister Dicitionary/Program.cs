using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeMinisterDict
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> primeMinister = new Dictionary<int, string>
            {
                { 1998,"Atal Bihari Vaj"},
                { 2014, "Narendra Modi"},
                { 2004, "Manmohan Singh"}
            };

            Console.WriteLine(primeMinister[2004]);
            primeMinister.Add(2018, "Some Name");

            IDictionary<string, byte> dict = new Dictionary<string, byte>() {
                { "1.0", 0x00 },
                { "1.1", 0x01 },
                { "1.2", 0x02 },
                { "1.3", 0x03 }
            };
            ReadOnlyDictionary<string, byte> read = new ReadOnlyDictionary<string, byte>(dict);

            foreach(var prime in primeMinister.OrderBy(key => key.Key))
            {
                Console.WriteLine("Key: {0}, Value: {1}", prime.Key, prime.Value);
            }
           

        }
    }
}
