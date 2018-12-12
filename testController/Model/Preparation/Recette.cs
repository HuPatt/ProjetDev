namespace Model.Preparation
{
    using System;

    internal class Recette
    {
        public string categorie;

        public int id_recette;

        public string titre;

        // public string ingredients;
        // public string materiel;
        public int tp_prep;

        public Recette(string titre)
        {
            switch (titre)
            {
                case "Soupe à la tomate":
                    this.tp_prep = 900000;
                    this.categorie = "entree";
                    break;
                case "Salade de cesar":
                    this.tp_prep = 300000;
                    this.categorie = "entree";
                    break;
                case "Kebabou":
                    this.tp_prep = 300000;
                    this.categorie = "plat";
                    break;
                case "Crevettes au curry":
                    this.tp_prep = 900000;
                    this.categorie = "plat";
                    break;
                case "Dessert aux cerises":
                    this.tp_prep = 900000;
                    this.categorie = "dessert";
                    break;
                case "Île flottante":
                    this.tp_prep = 600000;
                    this.categorie = "dessert";
                    break;
            }

            this.titre = titre;
            Console.WriteLine(titre);
            Console.ReadKey();
        }
    }
}