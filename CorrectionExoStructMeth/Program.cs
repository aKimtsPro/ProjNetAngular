using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionExoStructMeth
{
    

    struct Celcius
    {
        public double Temperature;

        public Fahrentheit Convert()
        {
            Fahrentheit f;
            f.Temperature = (Temperature * 9 / 5) + 32;
            return f;
        }
    }

    struct Fahrentheit
    {
        public double Temperature;

        public Celcius Convert()
        {
            Celcius c;
            c.Temperature = (Temperature - 32) * 5 / 9;
            return c;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Celcius c;
            Celcius c1;
            c.Temperature = 18.5;
            c1.Temperature = 26;

            Fahrentheit f;
            f.Temperature = 68;

            Console.WriteLine("PART 1");
            Console.WriteLine($"t° en fahr : {f.Temperature} | en celcius : {c.Temperature}");
            Console.WriteLine($"t° en de c1 : {c1.Temperature}" );

            Celcius c2;
            c2.Temperature = 10;
            Fahrentheit f2;
            f2.Temperature = 50;

            Console.WriteLine("PART 2");
            Console.WriteLine($"Temperature en celcius {c2.Temperature} | conversion : {c2.Convert().Temperature}");
            Console.WriteLine($"Temperature en fahrenheit {f2.Temperature} | conversion : {f2.Convert().Temperature}");

            Console.ReadLine();
        }
    }
}
