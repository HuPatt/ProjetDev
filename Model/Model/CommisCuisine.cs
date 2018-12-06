using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class CommisCuisine
    {
        int id_employe;
        String type;
        Boolean disponible;

        public CommisCuisine(int id_employe, string type, Boolean disponible)
        {
            this.id_employe = id_employe;
            this.type = type;
            this.disponible = disponible;
            Console.WriteLine("Je suis " + type);
            Console.ReadKey();
        }
    }
}
