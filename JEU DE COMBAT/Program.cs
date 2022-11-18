// See https://aka.ms/new-console-template for more information
using JEU_DE_COMBAT;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Bienvenue Jeune guerrier ...");
        Console.WriteLine("Avant de commencer, je voudrais savoir comment tu t'appeles ?");

        var hero = new Hero();

        string nom = Console.ReadLine();

        while (string.IsNullOrEmpty(nom))
        {
            Console.WriteLine("J'ai besoin de cette information pour que tu puisse poursuiver ton aventure !");
        }
        if (string.IsNullOrEmpty(nom))
        {
            Console.WriteLine("Désolé mais j'ai besoin de savoir pour que tu puisse avancer");
        }

        hero.NomPerso = nom;
        Console.WriteLine("Enchanté " + hero.NomPerso + " Bienvenue dans le multivers.");
        Console.WriteLine("Tu es arrivé pile dans les temps..." + "En effet, notre univers à été envahi par des monstres allant "
            + "du plus fort (les boss) et les plus faibles nommés les sbires");
        //Initialisation du nombre de monstre tués 
        int nbDeMonstresTues = 0;
        bool Equip = true;
        Random random = new Random();

        while (hero.IsDead)
        {
            Console.WriteLine(hero.PtDeVie);
            var monstre = new Monstre
            {
                NomMonstre = "Gremlins",
            };
            //Apparition du monstre dans le jeu
            Console.WriteLine("Attention, " + monstre.NomMonstre + " est un apparu... ");
            while (monstre.IsDead)
            {
                hero.Attaque(monstre);
                monstre.Attaque(hero);
            }
            int Lootchance = random.Next(1, 6);
            //Dès qu'un monstre meurt, on a une chance sur 6 de looter une arme (ce qui permet d'avoir une puissance d'attaque additionné à la force brute du personnage)
            if (Lootchance == 1)
            {
                Arme arme = new Arme();

                Console.WriteLine("Vous avez loot une arme avec " + arme.DegatParCoup + " de dégats ! Voulez-vous l'équiper ?");
                if (hero.Arme != null)
                {
                    Console.WriteLine("Dégâts de l'arme actuelle : " + hero.Arme.DegatParCoup);
                }
                else
                {
                    Console.WriteLine("Pas d'arme équipée actuellement.");
                }
                Console.WriteLine("1. Oui");
                Console.WriteLine("2. Non");
                //Dès que l'on appuie sur la touche Espace, cela équipe l'arme dans notre inventaire mais si on presse Entrée, cela nous enlève l'amre de notre inventaire
                
                if (Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    hero.UnequipWeapon();
                }
                else if (Console.ReadKey().Key == ConsoleKey.Spacebar)
                { 
                    hero.Equip(arme);
                    
                }
            }
            //Dès qu'un monstre est tué, cela augmente le nombre de monstre dans notre récapitulatif de fin de game
            nbDeMonstresTues++;
            
            // Utilisation d'une armure dans le jeu
            if (Lootchance == 1)
            {
                armure armure = new armure();

                Console.WriteLine("Vous trouvé une armure qui a une resistance de " + armure.resistance +
                ". Voulez-vous la porter pour avoir une meilleure défense et faire un meilleur score ?");

                if (armure.resistance == null)
                {
                    Console.WriteLine("Pas d'armure équipée actuellement.");
                }
                else
                {
                    
                    Console.WriteLine("Votre résistance actuelle : " + hero.PtDeVie);
                }
                Console.WriteLine("1. Oui");//Presser Espace
                Console.WriteLine("2. Non");//Presser Entrée

                if (Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    hero.UnequipArmur(armure);
                }else if(Console.ReadKey().Key == ConsoleKey.Spacebar)
                {
                    hero.Equip(armure);
                }
                    
                
            }

        }
        Console.WriteLine("GAME OVER !!!");

        Console.WriteLine("Nombre de monstres tués durant votre aventure : " + nbDeMonstresTues);

        Console.WriteLine("Appuyez sur une touche pour quitter");

        Console.ReadKey();

        return;
    }
}