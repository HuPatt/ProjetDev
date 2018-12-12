namespace Model.Employe
{
    using System;

    internal class Plongeur
    {
        public Plongeur(int id_employe, string type, bool disponible)
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
    }
}