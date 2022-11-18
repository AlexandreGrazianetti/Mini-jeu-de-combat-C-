using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JEU_DE_COMBAT
{
    public class armure
    {
       
        public int resistance { get; set; }

        public armure()
        {
            var random = new Random();

            resistance = random.Next(5, 20);

        }

        
    }
}

