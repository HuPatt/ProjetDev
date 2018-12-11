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

            //ComptoirCmdesPrep comptoir = new ComptoirCmdesPrep(commande, commande.serveur, commande.client);
            //Ludo.ComptoirCmdesPrep(commande, Ludo, commande.client);
        }
    }
}
