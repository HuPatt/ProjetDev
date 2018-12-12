namespace Model.Preparation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class ListeCommande
    {
        public List<Commande> listeCommandes = new List<Commande>();

        public ListeCommande(Commande commande)
        {
            this.listeCommandes.Add(new Commande(commande.id_commande, commande.client, commande.recette));
            Console.WriteLine("La commande N°" + commande.id_commande + " a été ajoutée à la liste");
            Console.ReadKey();
            Console.WriteLine(this.listeCommandes[0]);
            this.listeCommandes.ForEach(el => Console.WriteLine(el));
            Console.ReadKey();
        }

        public void GetList()
        {
            this.listeCommandes.Count();
        }
    }
}