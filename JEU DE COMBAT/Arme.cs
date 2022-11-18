using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JEU_DE_COMBAT
{
    public class Arme
    {
       public  int DegatParCoup { get; set; } = 10; 

        public Arme()
        {
            var random = new Random();

            DegatParCoup = random.Next(5, 20);
        }
    }
}
