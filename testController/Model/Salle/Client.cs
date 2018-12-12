namespace Model.Salle
{
    using System;
    using System.Threading;

    using Model.Employe;

    internal class Client
    {
        public Client(string nom, string gout, int tp_presence, int nb_appels)
        {
            this.nom = nom;
            this.gout = gout;
            this.tp_presence = tp_presence;
            this.nb_appels = nb_appels;
            Console.WriteLine("Je suis " + nom);
            Console.ReadKey();
        }

        public string nom { get; set; }

        private string gout { get; }

        private int nb_appels { get; }

        private float tp_presence { get; }

        public void Manger(int a, Client client)
        {
            Console.WriteLine("Je suis " + client.nom + " et je mange pendant : " + a);
            Console.ReadKey();
            Thread.Sleep(a);
        }

        public void Reserver(MaitreHotel maitreHotel)
        {
        }
    }
}