namespace Model.Employe
{
    internal class Employe
    {
        public Chef chef;

        public ChefRang chefrang;

        public Commande commande;

        public CommisCuisine commiscuisine;

        public CommisSalle commissalle;

        public Cuisinier cuisinier;

        public MaitreHotel maitrehotel;

        public Plongeur plongeur;

        public Serveur serveur;

        public Employe(int id_employe, string type, bool disponible)
        {
            this.id_employe = id_employe;
            this.type = type;
            this.disponible = disponible;

            switch (type)
            {
                case "chef":
                    this.chef = new Chef(id_employe, type, disponible);
                    break;
                case "chefrang":
                    this.chefrang = new ChefRang(id_employe, type, disponible);
                    break;
                case "commiscuisine":
                    this.commiscuisine = new CommisCuisine(id_employe, type, disponible);
                    break;
                case "commissalle":
                    this.commissalle = new CommisSalle(id_employe, type, disponible);
                    break;
                case "cuisinier":
                    this.cuisinier = new Cuisinier(id_employe, type, disponible);
                    break;
                case "maitrehotel":
                    this.maitrehotel = new MaitreHotel(id_employe, type, disponible);
                    break;
                case "plongeur":
                    this.plongeur = new Plongeur(id_employe, type, disponible);
                    break;
                case "serveur":
                    this.serveur = new Serveur(id_employe, type, disponible);
                    break;
            }
        }

        public bool disponible { get; set; }

        public int id_employe { get; set; }

        public string type { get; set; }
    }
}