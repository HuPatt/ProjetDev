namespace Model.Employe
{
    using System;
    using System.Threading;

    internal class ChefRang
    {
        private Commande commande;

        public ChefRang(int id_employe, string type, bool disponible)
        {
            this.id_employe = id_employe;
            this.type = type;
            this.disponible = disponible;
            Console.WriteLine("Nouveau " + type + " créé(e)");
            Console.ReadKey();
        }

        private bool disponible { get; }

        private int id_employe { get; }

        private string type { get; }

        public void Dresser(Table table)
        {
            Thread.Sleep(30000);
            table.disponible = true;
        }

        public void prendreCommande(Commande commande, Chef chef)
        {
            if (this.disponible)
            {
                this.commande = commande;
                Console.WriteLine(
                    "Le chef de rang N°" + this.id_employe + " a récupéré la commande de : " + commande.client.nom);
                Console.ReadKey();

                /*new ListeCommande(commande);*/
                commande.listeCom(commande);
                chef.prendreCommandes();
            }
            else
            {
                Console.WriteLine("Je suis le Chef de Rang N°" + this.id_employe + " et je ne suis pas dispo");
                Console.ReadKey();
            }
        }
    }
}