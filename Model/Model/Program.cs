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

             Mike.preparerCommande(commande);

             /*Sara.prendreCommandes(commande);
             Sara.prendreCommandes(commande);*/
        }
     
    }
}
