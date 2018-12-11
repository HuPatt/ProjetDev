using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Restaurant
    {
        public static SalleRestaurant salleRestaurant = new SalleRestaurant();
        public static EtagereSalle uneEtagere = new EtagereSalle();

        public static ChefRang Boby = new ChefRang(4, "chefrang", true);
        public static ChefRang Itachii = new ChefRang(5, "chefrang", true);
        public static Chef Sara = new Chef(6, "chef", true);
        public static Cuisinier Mike = new Cuisinier(7, "cuisinier", true);
        public static CommisCuisine Ron = new CommisCuisine(10, "commiscuisine", true);
        public static Serveur Ludo = new Serveur(20, "serveur", true);

        public static Client Patou = new Client("Patou", "bouffedemerde", 15, 2);
        public static Client Theo = new Client("Théo", "bouffedemerde", 30, 3);

        public static Table A = new Table(1, 4, true);

        public static Recette Kebabou = new Recette("Kebabou");
        public static Recette SaladeC = new Recette("Salade de cesar");

        public static Commande commande = new Commande(123, Patou, Kebabou);
        public static Commande commande2 = new Commande(234, Theo, SaladeC);

        

        public Restaurant()
        {
            salleRestaurant.setCarre(2);
            salleRestaurant.setRang(4);
            salleRestaurant.setSalleRestauration(1);

            Console.WriteLine("Le carre est : " + salleRestaurant.getCarre() + "\n" + "Le rang est : " + salleRestaurant.getRang());
            Console.Read();

            //------------------------------------------------------------------------------------------------------

            uneEtagere.SetCarte(50);
            uneEtagere.SetEau(120);
            uneEtagere.SetPain(120);

            Console.WriteLine(
                " le nombre de carte : " + uneEtagere.GetCarte() + ", le nombre de de l'eau : " + uneEtagere.GetEau()
                + " et le nombre de pain : " + uneEtagere.GetPain());

            uneEtagere.DecremPain(2);
            uneEtagere.decremCarte(5);
            uneEtagere.decremEau(2);
            Console.WriteLine(
                " le nombre de carte : " + uneEtagere.GetCarte() + ", le nombre de de l'eau : " + uneEtagere.GetEau()
                + " et le nombre de pain : " + uneEtagere.GetPain());

            Console.Read();

            //------------------------------------------------------------------------------------------------------

            /*Employe Boris = new Employe(1, "chef", true);
             Employe John = new Employe(2, "cuisinier", true);
             Employe Mick = new Employe(3, "plongeur", true);
             Employe Theo = new Employe(4, "serveur", true);*/

            A.reservationClient(Patou, A);

            Boby.prendreCommande(commande, Sara);
            Itachii.prendreCommande(commande2, Sara);

            A.reservationClient(Theo, A);
            Mike.prendreOrdres();

            Mike.preparerCommande(commande, Ron);
            Mike.preparerCommande(commande2, Ron);
            
            //Sara.prendreCommandes(commande);
            //Sara.prendreCommandes(commande);

        }
    }
}
