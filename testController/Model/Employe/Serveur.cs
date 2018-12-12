
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Serveur
    {
        public int id_employe { get; set; }
        public string type { get; set; }
        public Boolean disponible { get; set; }

        public Serveur(int id_employe, string type, Boolean disponible)
        {
            this.id_employe = id_employe;
            this.type = type;
            this.disponible = disponible;
            Console.WriteLine("Nouveau " + type + " créé(e)");
            Console.ReadKey();
        }


        public void ComptoirCmdesPrep(Commande commande, Serveur serveur, Client client)
        {
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
                ComptoirCmdesPrep(commande, serveur, client);
            }
        }

        public void Servir(Client client, Commande commande)
        {
            //mettre dans le constructeur un objet PREPARATION DU CUISINIER qui possède un type (plat, entree, dessert)
            switch (commande.recette.categorie)
            {
                case "entree":
                    client.Manger(1000, client);
                    break;
                case "plat":
                    client.Manger(2000, client);
                    break;
                case "dessert":
                    client.Manger(3000, client);
                    break;
            }
        }

        public void Debarasser(Table table)
        {
            table.disponible = false;
            System.Threading.Thread.Sleep(30000);
        }
    }
}
