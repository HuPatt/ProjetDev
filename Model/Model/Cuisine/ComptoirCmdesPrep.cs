using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ComptoirCmdesPrep
    {
        public List<string> listeCommandesPrep = new List<string>();

        public ComptoirCmdesPrep(Commande commande)
        {
            listeCommandesPrep.Add(commande.id_commande.ToString() + commande.client + commande.recette);
            Console.WriteLine("La commande N°" + commande.id_commande + " a été déposé sur le Comptoir");
            Console.ReadKey();
            Console.WriteLine(listeCommandesPrep[0]);
            listeCommandesPrep.ForEach(el => Console.WriteLine(el));
            Console.ReadKey();
        }

        public void GetList()
        {
            listeCommandesPrep.Count();
        }
    }
}
