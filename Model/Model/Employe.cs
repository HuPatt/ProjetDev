using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Employe
    {
        int id_employe;
        String type;
        Boolean disponible;

        Chef chef;
        ChefRang chefrang;
        CommisCuisine commiscuisine;
        CommisSalle commissalle;
        Cuisinier cuisinier;
        MaitreHotel maitrehotel;
        Plongeur plongeur;
        Serveur serveur;


        public Employe(int id_employe, string type, Boolean disponible)
        {
            this.id_employe = id_employe;
            this.type = type;
            this.disponible = disponible;

            if (type == "chef")
            {
                chef = new Chef(id_employe, type, disponible);
            }

            if (type == "chefrang")
            {
                chefrang = new ChefRang(id_employe, type, disponible);
            }

            if (type == "commiscuisine")
            {
                commiscuisine = new CommisCuisine(id_employe, type, disponible);
            }

            if (type == "commissalle")
            {
                commissalle = new CommisSalle(id_employe, type, disponible);
            }

            if (type == "cuisinier")
            {
                cuisinier = new Cuisinier(id_employe, type, disponible);
            }

            if (type == "maitrehotel")
            {
                maitrehotel = new MaitreHotel(id_employe, type, disponible);
            }

            if (type == "plongeur")
            {
                plongeur = new Plongeur(id_employe, type, disponible);
            }

            if (type == "serveur")
            {
                serveur = new Serveur(id_employe, type, disponible);
            }

        }
    }
}
