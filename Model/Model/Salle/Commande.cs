using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Commande
    {
        public int id_commande { get; set; }
        public Recette recette;
        public Client client;
        public Serveur serveur;
        /* public List<string> listeCommandes = new List<string>();*/
        public static string[,] listCommandes = new string[10, 3];
        private int i;


        public Commande(int id_commande, Client client, Recette recette)
        {
            this.id_commande = id_commande;
            this.client = client;
            this.recette = recette;
           /* Console.WriteLine("Le client " + client.nom + " a commandé : " + recette.titre);
            Console.ReadKey();
            Console.WriteLine("Capacité de la liste : " + listeCommandes.Capacity);
            Console.ReadKey();*/
        }

        public void listeCom(Commande commande)
        {
            for (i = 0; i <= 10; i++)
            {
                if (listCommandes[i, 0] is null)
                {
                    listCommandes[i, 0] = commande.id_commande.ToString();
                    listCommandes[i, 1] = commande.recette.titre;
                    listCommandes[i, 2] = commande.client.nom;
                    Console.WriteLine(listCommandes[i, 0] + " " + listCommandes[i, 1] + " " + listCommandes[i, 2] + " i : " + i);
                    Console.ReadKey();
                    i = 10;
                }
            }
        }

        public void supprimerCom(Commande commande)
        {

        }



        /*public void listeComm(Commande commande)
        {
            listeCommandes.Add(commande.id_commande.ToString() + "-" + commande.recette.titre + "-" + commande.client.nom + ";");
            Console.WriteLine("La commande N°" + commande.id_commande + " a été ajoutée à la liste");
            Console.ReadKey();
            listeCommandes.ForEach(el => Console.WriteLine(el));
            Console.ReadKey();
        }*/
    }
}
