using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JEU_DE_COMBAT
{
    public class Hero
    {
        public string NomPerso { get; set; }
        public int AttaCorp { get; set; }
        public int PtDeVie { get; set; } = 100;
        public bool IsDead { get; set; } = true;
        public Arme Arme { get; set; }

        public bool VieouMort {get; set; }

        public int XP {get; set; }

        public armure Armure { get; set; }

        public Hero()
        {
            var random = new Random();

            AttaCorp = random.Next(10, 30);
        }

        public void Equip(Arme arme)
        {
            AttaCorp = AttaCorp + arme.DegatParCoup;
            Arme = arme;
        }

        public void UnequipWeapon()
        {
            if(Arme == null)
            {
                return;
            }

            AttaCorp = AttaCorp - Arme.DegatParCoup;

            Arme = null;
        }

        public void Attaque(Monstre monstre)
        {
            monstre.SubirDegats(AttaCorp);
        }
        public void SubirDegats(int degats)
        {
            PtDeVie = PtDeVie - degats;

            if(PtDeVie <= 0)
            {
                IsDead = false;
            }
        }
        public void Equip(armure armure)
        {
            PtDeVie += armure.resistance;
            
        }

        public void UnequipArmur(armure armure)
        {
            if (armure.resistance == null)
            {
                return;
            }

            PtDeVie -= armure.resistance;

        }

        public void resistance(int resistance)
        {

             PtDeVie = PtDeVie + resistance;
        }
        
    }
}
