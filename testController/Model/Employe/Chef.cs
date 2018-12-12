namespace Model.Employe
{
    using System;

    internal class Chef
    {
        // Commande listCommandes;
        // Cuisinier cuisinier;
        public Chef(int id_employe, string type, bool disponible)
        {
            this.id_employe = id_employe;
            this.type = type;
            this.disponible = disponible;
            Console.WriteLine("Nouveau " + type + " créé(e)");
            Console.ReadKey();
        }

        private bool disponible { get; set; }

        private int id_employe { get; }

        private string type { get; }

        public void checkStock()
        {
        }

        public void donnerOrdres(Cuisinier cuisinier)
        {
            cuisinier.prendreOrdres();
        }

        public void prendreCommandes()
        {
            if (this.disponible)
            {
                /*this.commande = commande;
                Console.WriteLine("Nombre de commandes dans la liste : " + commande.listeCommandes.Count());
                Console.ReadKey();
                commande.listeCommandes.ForEach(el => Console.WriteLine(el));
                Console.ReadKey();
                commande.listeCommandes.ForEach(Console.WriteLine);
                Console.ReadKey();
                Console.WriteLine("Je suis le chef N°" + id_employe + " et j'ai récupéré la commande : " + commande.id_commande);
                Console.ReadKey();*/
                Console.WriteLine(
                    "Je suis le chef et je récupère : " + Commande.listCommandes[0, 0] + " "
                    + Commande.listCommandes[0, 1] + " " + Commande.listCommandes[0, 2]);
                Console.ReadKey();

                // Commande.listCommandes[0, 0];
                // Cuisinier cuisinier;
                // cuisinier.prendreOrdres(listCommandes);
                // donnerOrdres();
                for (var i = 0; i <= 10; i++)
                {
                    Commande.listCommandes[i, 0] = Commande.listCommandes[i + 1, 0];
                    Commande.listCommandes[i, 1] = Commande.listCommandes[i + 1, 1];
                    Commande.listCommandes[i, 2] = Commande.listCommandes[i + 1, 2];
                    i = 10;
                }

                /*Commande.listCommandes[0, 0] = Commande.listCommandes[1, 0];
                Commande.listCommandes[0, 1] = Commande.listCommandes[1, 1];
                Commande.listCommandes[0, 2] = Commande.listCommandes[1, 2];*/
                Console.WriteLine(
                    "Je suis le chef et la prochaine commande est : " + Commande.listCommandes[1, 0] + " "
                    + Commande.listCommandes[1, 1] + " " + Commande.listCommandes[1, 2]);
                Console.ReadKey();
                this.disponible = false;
            }
            else
            {
                Console.WriteLine("Je suis le chef N°" + this.id_employe + " et je ne suis pas dispo");
            }
        }
    }
}