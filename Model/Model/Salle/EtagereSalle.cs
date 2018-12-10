using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{

    public class Etagere
    {
        private static Etagere uneEtagere;

        // attributs
        private int nbcarte;

        private int nbeau;

        private int nbpain;

        public void decremCarte(int a)
        {
            this.nbcarte = this.nbcarte - a;
        }

        public void decremEau(int a)
        {
            this.nbeau = this.nbeau - a;
        }

        public void DecremPain(int a)
        {
            this.nbpain = this.nbpain - a;
        }

        public int GetCarte()
        {
            return this.nbcarte;
        }

        public int GetEau()
        {
            return this.nbeau;
        }

        public int GetPain()
        {
            return this.nbpain;
        }

        // les accesseurs en lecture
        public void SetCarte(int nCarte)
        {
            this.nbcarte = nCarte;
        }

        public void SetEau(int nEau)
        {
            this.nbeau = nEau;
        }

        public void SetPain(int nPain)
        {
            this.nbpain = nPain;
        }

        private static void Main(string[] args)
        {
            // déclarer une référence sur l'objet

            // Créer un objet => constructeur généré par defaut
            uneEtagere = new Etagere();
            uneEtagere.SetCarte(50);
            uneEtagere.SetEau(120);
            uneEtagere.SetPain(120);

            /*
                        //créer un objet
                        uneEtagere = new CtEtagere("les cartes", "de l'eau","les pains");
            
                        Console.WriteLine(" Les éléments de l'étagère sont " + uneEtagere.GetCarte() + ", " + uneEtagere.GetEau() + " et " + uneEtagere.GetPain());
                      
            
                        CtEtagere[] uneEtagere;
                        uneEtagere = new CtEtagere[1];
                        uneEtagere[0] = new CtEtagere();
                        for (int ind = 0; ind < uneEtagere.Length; ind++)
                        {
                            Console.WriteLine(" L'élément situé à l'indice " + ind + " le nombre de carte : " + uneEtagere[ind].GetCarte() + ", le nombre de de l'eau : " + uneEtagere[ind].GetEau() + " et le nombre de pain : " + uneEtagere[ind].GetPain());
                        }
                      */
            Console.WriteLine(
                " le nombre de carte : " + uneEtagere.GetCarte() + ", le nombre de de l'eau : " + uneEtagere.GetEau()
                + " et le nombre de pain : " + uneEtagere.GetPain());

            uneEtagere.DecremPain(2);
            uneEtagere.decremCarte(5);
            uneEtagere.decremEau(2);
            Console.WriteLine(
                " le nombre de carte : " + uneEtagere.GetCarte() + ", le nombre de de l'eau : " + uneEtagere.GetEau()
                + " et le nombre de pain : " + uneEtagere.GetPain());

            Console.Read();
        }
    }
}