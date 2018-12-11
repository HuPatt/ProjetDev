using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Cuisinier
    {
        int id_employe {get; set;}
        string type {get; set;}
        Boolean disponible {get; set;}
        //Commande commande;

        public Cuisinier(int id_employe, string type, Boolean disponible)
        {
            this.id_employe = id_employe;
            this.type = type;
            this.disponible = disponible;
            Console.WriteLine("Nouveau " + type + " créé(e)");
            Console.ReadKey();
        }

        public void prendreOrdres()
        {
            if (disponible == true) {
                //this.commande = commande;
                //Console.WriteLine("Je suis le cuisinier N°" + id_employe + " et je prépare la commande : " + commande.id_commande);
                //Console.ReadKey();
                disponible = false;
                Console.WriteLine("Je suis le cuisinier N°" + id_employe + " et j'ai pris la commande : " + Commande.listCommandes[0, 0]);
                Console.ReadKey();
            }

        }

        public void preparerCommande(Commande commande, CommisCuisine commisCuisine)
        {
            //récupérer la recette concernée par la commande
            //mettre dans la variable a le temps de préparation de cette commande
            //décrémenté les ingrédients
            
            Console.WriteLine("Le cuisinier va travailler pendant : " + commande.recette.tp_prep);
            Console.ReadKey();
            commisCuisine.ApporterCommande(commande);

            //System.Threading.Thread.Sleep(commande.recette.tp_prep);

        }

    }
}
