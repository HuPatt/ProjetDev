namespace Model.Employe
{
    using System;

    internal class MaitreHotel
    {
        public MaitreHotel(int id_employe, string type, bool disponible)
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

        public void ReserverTable(Client client, Table table)
        {
            table.reservationClient(client, table);
        }
    }
}

}