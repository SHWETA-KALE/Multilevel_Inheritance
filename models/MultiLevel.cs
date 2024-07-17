using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLevelInheritanceDemo.models
{
    internal class MultiLevel
    {
        public class Country
        {
            public void Name()
            {
                Console.WriteLine("The Name of the country is India");

            }
        }

        public class State: Country {
        
            public void Capital()
            {
                Console.WriteLine("The Capital of the state Maharashtra is Mumbai");
            }
        }

        public class City:State
        {
            public void Food()
            {
                Console.WriteLine("The famous food is Vada Pav");
            }
        }
    }
}
