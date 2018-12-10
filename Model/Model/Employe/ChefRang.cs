using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ChefRang
    {
        int id_employe {get; set;}
        string type {get; set;}
        Boolean disponible {get; set;}
        Commande commande;

        public ChefRang(int id_employe, string type, Boolean disponible)
        {
                this.id_employe = id_employe;
                this.type = type;
                this.disponible = disponible;
                Console.WriteLine("Nouveau " + type + " créé(e)");
                Console.ReadKey();
            
        }

        public void prendreCommande(Commande commande, Chef chef){
            if (disponible == true)
            {
                this.commande = commande;
                Console.WriteLine("Le chef de rang N°" + id_employe + " a récupéré la commande de : " + commande.client.nom);
                Console.ReadKey();
                /*new ListeCommande(commande);*/
                commande.listeCom(commande);
                chef.prendreCommandes();
            }
            else
            {
                Console.WriteLine("Je suis le Chef de Rang N°" + id_employe + " et je ne suis pas dispo");
                Console.ReadKey();
            }
        }

        public void Dresser(Table table)
        {
            System.Threading.Thread.Sleep(30000);
            table.disponible = true;
        }

    }
}
