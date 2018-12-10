using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Serveur
    {
        int id_employe {get; set;}
        String type {get; set;}
        Boolean disponible {get; set;}

        public Serveur(int id_employe, string type, Boolean disponible)
        {
            this.id_employe = id_employe;
            this.type = type;
            this.disponible = disponible;
            Console.WriteLine("Nouveau " + type + " créé(e)");
            Console.ReadKey();
        }

        public void Servir(Client client)
        {
            //mettre dans le constructeur un objet PREPARATION DU CUISINIER qui possède un type (plat, entree, dessert)
            switch (type)
            {
                case "entree":
                    client.Manger(150000);
                    break;
                case "plat":
                    client.Manger(250000);
                    break;
                case "dessert":
                    client.Manger(150000);
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
