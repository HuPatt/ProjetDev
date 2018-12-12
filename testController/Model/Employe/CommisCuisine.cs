namespace Model.Employe
{
    using System;

    internal class CommisCuisine
    {
        public CommisCuisine(int id_employe, string type, bool disponible)
        {
            this.id_employe = id_employe;
            this.type = type;
            this.disponible = disponible;
            Console.WriteLine("Nouveau " + type + " créé(e)");
            Console.ReadKey();
        }

        public bool disponible { get; set; }

        public int id_employe { get; set; }

        public string type { get; set; }

        public void ApporterCommande(Commande commande)
        {
            Console.WriteLine("Le commis apporte la commande : " + commande.client.nom);
            Console.ReadKey();

            // ComptoirCmdesPrep comptoir = new ComptoirCmdesPrep(commande, commande.serveur, commande.client);
            // Ludo.ComptoirCmdesPrep(commande, Ludo, commande.client);
        }
    }
}