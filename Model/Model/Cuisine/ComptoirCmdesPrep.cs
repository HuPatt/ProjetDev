using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ComptoirCmdesPrep
    {
        //public List<string> listeCommandesPrep = new List<string>();

        public static string[,] listPlats = new string[10, 3];
        private int i;

        public ComptoirCmdesPrep(Commande commande, Serveur serveur)
        {
            /*listeCommandesPrep.Add(commande.id_commande.ToString() + commande.client + commande.recette);
            Console.WriteLine("La commande N°" + commande.id_commande + " a été déposé sur le Comptoir");
            Console.ReadKey();
            Console.WriteLine(listeCommandesPrep[0]);
            listeCommandesPrep.ForEach(el => Console.WriteLine(el));
            Console.ReadKey();
            if (serveur.disponible == true)
            {
                serveur.Servir(client, commande);
                Console.WriteLine("La commande suivante a été envoyé : " + commande.id_commande);
                Console.ReadKey();
                serveur.disponible = false;
            }
            else
            {
                Console.WriteLine("Le serveur demandé n'est pas disponible");
                Console.ReadKey();
                //System.Threading.Thread.Sleep(50000);
                //comptoirCmdesPrep(commande, serveur, client);
            }*/
            
            serveur.disponible = true;

            for (i = 0; i <= 10; i++)
            {
                if (listPlats[i, 0] is null)
                {
                    listPlats[i, 0] = commande.id_commande.ToString();
                    listPlats[i, 1] = commande.recette.titre;
                    listPlats[i, 2] = commande.client.nom;
                    Console.WriteLine(listPlats[i, 0] + " " + listPlats[i, 1] + " " + listPlats[i, 2] + " i : " + i);
                    Console.ReadKey();
                    i = 10;
                }
            }
            
            if (listPlats[0,0] != null && serveur.disponible == true)
            {
                Console.WriteLine("Le serveur est en action !");
                Console.ReadKey();
                serveur.recupComptoirCmdesPrep(commande, serveur, commande.client);
            }
            
        }

        public void GetList()
        {
            //listeCommandesPrep.Count();
        }
    }
}
