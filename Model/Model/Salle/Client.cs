using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Client
    {
        public string nom {get; set;}
        string gout {get; set;}
        float tp_presence {get; set;}
        int nb_appels {get; set;}

        public Client(string nom, string gout, int tp_presence, int nb_appels){
            this.nom = nom;
            this.gout = gout;
            this.tp_presence = tp_presence;
            this.nb_appels = nb_appels;
            Console.WriteLine("Je suis " + nom);
            Console.ReadKey();
        }

        public void Reserver(MaitreHotel maitreHotel)
        {
            =
        }

        public void Manger(int a, Client client)
        {
            Console.WriteLine("Je suis "+ client.nom + " et je mange pendant : " + a);
            Console.ReadKey();
            System.Threading.Thread.Sleep(a);
        }
    }
}
