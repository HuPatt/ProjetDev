using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class CommisCuisine
    {
        public int id_employe {get; set;}
        public string type {get; set;}
        public Boolean disponible {get; set; }

        public CommisCuisine(int id_employe, string type, Boolean disponible)
        {
            this.id_employe = id_employe;
            this.type = type;
            this.disponible = disponible;
            Console.WriteLine("Nouveau " + type + " créé(e)");
            Console.ReadKey();
        }

        public void ApporterCommande(Commande commande)
        {
            Console.WriteLine("Le commis apporte la commande : " + commande.client.nom);
            Console.ReadKey();

            ComptoirCmdesPrep comptoir = new ComptoirCmdesPrep(commande, Restaurant.Ludo);

            for (int i = 0; i < 10; i++)
            {
                if (i < 9)
                {
                    ComptoirCmdesPrep.listPlats[i, 0] = ComptoirCmdesPrep.listPlats[i + 1, 0];
                    ComptoirCmdesPrep.listPlats[i, 1] = ComptoirCmdesPrep.listPlats[i + 1, 1];
                    ComptoirCmdesPrep.listPlats[i, 2] = ComptoirCmdesPrep.listPlats[i + 1, 2];
                }
                else
                {
                    ComptoirCmdesPrep.listPlats[i, 0] = "";
                    ComptoirCmdesPrep.listPlats[i, 1] = "";
                    ComptoirCmdesPrep.listPlats[i, 2] = "";
                }
            }

            //ComptoirCmdesPrep comptoir = new ComptoirCmdesPrep(commande, commande.serveur, commande.client);
            //Ludo.ComptoirCmdesPrep(commande, Ludo, commande.client);
        }
    }
}
