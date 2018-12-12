namespace Model.Cuisine
{
    internal class ComptoirCmdesPrep
    {
        // public List<string> listeCommandesPrep = new List<string>();
        public ComptoirCmdesPrep(Commande commande, Serveur serveur, Client client)
        {
            /*listeCommandesPrep.Add(commande.id_commande.ToString() + commande.client + commande.recette);
            Console.WriteLine("La commande N°" + commande.id_commande + " a été déposé sur le Comptoir");
            Console.ReadKey();
            Console.WriteLine(listeCommandesPrep[0]);
            listeCommandesPrep.ForEach(el => Console.WriteLine(el));
            Console.ReadKey();
            if (serveur.disponible == true)
            {
                serveur.Servir(client, commande);
                Console.WriteLine("La commande suivante a été envoyé : " + commande.id_commande);
                Console.ReadKey();
                serveur.disponible = false;
            }
            else
            {
                Console.WriteLine("Le serveur demandé n'est pas disponible");
                Console.ReadKey();
                //System.Threading.Thread.Sleep(50000);
                //comptoirCmdesPrep(commande, serveur, client);
            }*/
        }

        public void GetList()
        {
            // listeCommandesPrep.Count();
        }
    }
}