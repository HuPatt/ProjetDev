using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Chef
    {
        int id_employe {get; set;}
        String type {get; set;}
        Boolean disponible {get; set;}
        //Commande listCommandes;
        //Cuisinier cuisinier;

        public Chef(int id_employe, string type, Boolean disponible)
        {
            this.id_employe = id_employe;
            this.type = type;
            this.disponible = disponible;
            Console.WriteLine("Nouveau " + type + " créé(e)");
            Console.ReadKey();     
        }

        public void prendreCommandes(){
            if (disponible == true) {
                /*this.commande = commande;
                Console.WriteLine("Nombre de commandes dans la liste : " + commande.listeCommandes.Count());
                Console.ReadKey();
                commande.listeCommandes.ForEach(el => Console.WriteLine(el));
                Console.ReadKey();
                commande.listeCommandes.ForEach(Console.WriteLine);
                Console.ReadKey();
                Console.WriteLine("Je suis le chef N°" + id_employe + " et j'ai récupéré la commande : " + commande.id_commande);
                Console.ReadKey();*/
                Console.WriteLine("Je suis le chef et je récupère : " + Commande.listCommandes[0, 0] + " " + Commande.listCommandes[0, 1] + " " + Commande.listCommandes[0, 2]);
                Console.ReadKey();
                //Commande.listCommandes[0, 0];
                //Cuisinier cuisinier;
                //cuisinier.prendreOrdres(listCommandes);
                //donnerOrdres();

                for (int i = 0; i <= 10; i++)
                {
                        Commande.listCommandes[i, 0] = Commande.listCommandes[i+1, 0];
                        Commande.listCommandes[i, 1] = Commande.listCommandes[i+1, 1];
                        Commande.listCommandes[i, 2] = Commande.listCommandes[i+1, 2];
                        i = 10;
                }

                /*Commande.listCommandes[0, 0] = Commande.listCommandes[1, 0];
                Commande.listCommandes[0, 1] = Commande.listCommandes[1, 1];
                Commande.listCommandes[0, 2] = Commande.listCommandes[1, 2];*/

                Console.WriteLine("Je suis le chef et la prochaine commande est : " + Commande.listCommandes[0, 0] + " " + Commande.listCommandes[0, 1] + " " + Commande.listCommandes[0, 2]);
                Console.ReadKey();

            }
            else
            {
                Console.WriteLine("Je suis le chef N°" + id_employe + " et je ne suis pas dispo" );
            }
        }

        public void donnerOrdres(Cuisinier cuisinier)
        {
            cuisinier.prendreOrdres();
        }

        public void checkStock(){

        }
    }
}
