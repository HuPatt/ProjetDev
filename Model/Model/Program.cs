using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Program
    {
        static void Main(string[] args)
        {
            Employe Boris = new Employe(1, "chef", false);
            Employe John = new Employe(2, "cuisinier", false);
            Employe Mick = new Employe(3, "plongeur", false);
            Employe Theo = new Employe(4, "serveur", false);
        }
    }
}
