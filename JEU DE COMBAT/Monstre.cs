using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JEU_DE_COMBAT
{
    public class Monstre
    {
        public string NomMonstre { get; set; }
        public int AttaCorp { get; set; } = 1;
        public int DefCorp {get; set; }
        public int PtDeVie { get; set; } = 10;
        public bool IsDead { get; set; } = true;

        public Monstre()
        {
            var random = new Random();

            AttaCorp = random.Next(1, 2);
            DefCorp = random.Next(10, 20);
        }
        
        public void Attaque(Hero hero) 
        {
            hero.SubirDegats(AttaCorp);
        }

        public void SubirDegats(int degats)
        {
            PtDeVie = PtDeVie - degats;

            if (PtDeVie <= 0)
            {
                IsDead = false;
            }
        }
    }
}
