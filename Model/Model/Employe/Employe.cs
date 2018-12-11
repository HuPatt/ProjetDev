using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Employe
    {
        public int id_employe {get; set;}
        public string type {get; set;}
        public Boolean disponible {get; set;}

        public Chef chef;
        public ChefRang chefrang;
        public CommisCuisine commiscuisine;
        public CommisSalle commissalle;
        public Cuisinier cuisinier;
        public MaitreHotel maitrehotel;
        public Plongeur plongeur;
        public Serveur serveur;

        public Commande commande;

        public Employe(int id_employe, string type, Boolean disponible)
        {
            this.id_employe = id_employe;
            this.type = type;
            this.disponible = disponible;

            
            switch (type)
	        {
		        case "chef":
                    chef = new Chef(id_employe, type, disponible);
                    break;
                case "chefrang":
                    chefrang = new ChefRang(id_employe, type, disponible);
                    break;
                case "commiscuisine":
                    commiscuisine = new CommisCuisine(id_employe, type, disponible);
                    break;
                case "commissalle":
                    commissalle = new CommisSalle(id_employe, type, disponible);
                    break;
                case "cuisinier":
                    cuisinier = new Cuisinier(id_employe, type, disponible);
                    break;
                case "maitrehotel":
                    maitrehotel = new MaitreHotel(id_employe, type, disponible);
                    break;
                case "plongeur":
                    plongeur = new Plongeur(id_employe, type, disponible);
                    break;
                case "serveur":
                    serveur = new Serveur(id_employe, type, disponible);
                    break;
	        }

 

        }
    }
}
