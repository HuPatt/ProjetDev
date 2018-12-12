using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Table
    {
        public int id_table { get; set; }
        public int nb_places { get; set; }
        public Boolean disponible { get; set; }

        public Table(int id_table, int nb_places, Boolean disponible)
        {
            this.id_table = id_table;
            this.nb_places = nb_places;
            this.disponible = disponible;
            Console.WriteLine("Je suis la table N°" + id_table + " et je suis " + disponible);
            Console.ReadKey();
        }

        public void reservationClient(Client client, Table table)
        {
            if(table.disponible == true)
            {
                table.disponible = false;
                Console.WriteLine("La table N°" + id_table + " a été reservé par " + client.nom + " -- Etat : " + table.disponible);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("La table N°" + id_table + " est déjà occupée");
                Console.ReadKey();
            }
        }

        public void liberationTable(Table table)
        {
            table.disponible = true;
        }



    }
}
