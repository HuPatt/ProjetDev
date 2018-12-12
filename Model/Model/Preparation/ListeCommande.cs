using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ListeCommande
    {
        public List<Commande> listeCommandes = new List<Commande>();

        public ListeCommande(Commande commande)
        {
            listeCommandes.Add(new Commande(commande.id_commande, commande.client, commande.recette));
            Console.WriteLine("La commande N°" + commande.id_commande + " a été ajoutée à la liste");
            Console.ReadKey();
            Console.WriteLine(listeCommandes[0]);
            listeCommandes.ForEach(el => Console.WriteLine(el));
            Console.ReadKey();
        }

        public void GetList()
        {
             listeCommandes.Count();
        }

    }
}
