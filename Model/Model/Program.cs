using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Program
    {
        static void Main(string[] args)
         {
             /*Employe Boris = new Employe(1, "chef", true);
             Employe John = new Employe(2, "cuisinier", true);
             Employe Mick = new Employe(3, "plongeur", true);
             Employe Theo = new Employe(4, "serveur", true);*/

             ChefRang Boby = new ChefRang(4, "chefrang", true);
             ChefRang Itachii = new ChefRang(5, "chefrang", true);
             Chef Sara = new Chef(6, "chef", true);
             Cuisinier Mike = new Cuisinier(7, "cuisinier", true);
             CommisCuisine Ron = new CommisCuisine(10, "commiscuisine", true);
             //Serveur Ludo = new Serveur(20, "serveur", true);

             Client Rick = new Client("Patou","bouffedemerde", 15, 2);
             Client Morty = new Client("Théo", "bouffedemerde", 30, 3);

             Table A = new Table(1, 4, true);
             A.reservationClient(Rick,A);

             Recette Burger = new Recette("Kebabou");
             Recette Soupe = new Recette("SoupeDeThéo");

             Commande commande = new Commande(123,Rick,Burger);
             Commande commande2 = new Commande(234, Morty, Soupe);

             Boby.prendreCommande(commande, Sara);
             Itachii.prendreCommande(commande2, Sara);

             A.reservationClient(Morty, A);
             Mike.prendreOrdres();

             Mike.preparerCommande(commande, Ron);


            /*Sara.prendreCommandes(commande);
            Sara.prendreCommandes(commande);*/
            Etagere uneEtagere = new Etagere();
            uneEtagere.SetCarte(50);
            uneEtagere.SetEau(120);
            uneEtagere.SetPain(120);

            /*
                        //créer un objet
                        uneEtagere = new CtEtagere("les cartes", "de l'eau","les pains");
            
                        Console.WriteLine(" Les éléments de l'étagère sont " + uneEtagere.GetCarte() + ", " + uneEtagere.GetEau() + " et " + uneEtagere.GetPain());
                      
            
                        CtEtagere[] uneEtagere;
                        uneEtagere = new CtEtagere[1];
                        uneEtagere[0] = new CtEtagere();
                        for (int ind = 0; ind < uneEtagere.Length; ind++)
                        {
                            Console.WriteLine(" L'élément situé à l'indice " + ind + " le nombre de carte : " + uneEtagere[ind].GetCarte() + ", le nombre de de l'eau : " + uneEtagere[ind].GetEau() + " et le nombre de pain : " + uneEtagere[ind].GetPain());
                        }
                      */


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

            /////////////////////////////////////////////////////

            CtRestaurant unRestaurant;

            unRestaurant = new CtRestaurant();

            unRestaurant.setCarre(2);
            unRestaurant.setRang(4);
            unRestaurant.setSalleRestauration(1);

            Console.WriteLine("Le carre est : " + unRestaurant.getCarre() + "\n" + "Le rang est : " + unRestaurant.getRang());
            Console.Read();
        }
     
    }
}
