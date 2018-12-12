using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Recette
    {
        public int id_recette;
        public string titre;
        //public string ingredients;
        //public string materiel;
        public int tp_prep;
        public string categorie;

        public Recette(string titre)
        {
            switch (titre)
            {
                case "Soupe à la tomate":
                    tp_prep = 900000;
                    categorie = "entree";
                    break;
                case "Salade de cesar":
                    tp_prep = 300000;
                    categorie = "entree";
                    break;
                case "Kebabou":
                    tp_prep = 300000;
                    categorie = "plat";
                    break;
                case "Crevettes au curry":
                    tp_prep = 900000;
                    categorie = "plat";
                    break;
                case "Dessert aux cerises":
                    tp_prep = 900000;
                    categorie = "dessert";
                    break;
                case "Île flottante":
                    tp_prep = 600000;
                    categorie = "dessert";
                    break;
            }

            this.titre = titre;
            Console.WriteLine(titre);
            Console.ReadKey();
        }
    }
}
