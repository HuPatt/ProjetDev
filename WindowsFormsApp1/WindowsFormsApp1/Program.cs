using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        /// 
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            
        }

        /*class test
        {
            string recuperer;

            public test(string recuperer)
            {
                this.recuperer = recuperer;
            }

            public void recuptextbox()
            {
                System.Console.WriteLine(recuperer);
                Console.Read();

            }
        }*/
    }
    }

