using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class MaitreHotel
    {
        int id_employe { get; set; }
        String type { get; set; }
        Boolean disponible { get; set; }

        public MaitreHotel(int id_employe, string type, Boolean disponible)
        {
            this.id_employe = id_employe;
            this.type = type;
            this.disponible = disponible;
            Console.WriteLine("Nouveau " + type + " créé(e)");
            Console.ReadKey();
        }

        public void ReserverTable(Client client, Table table)
        {
            table.reservationClient(client, table);
        }
    }
}
