using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class EtagereSalle
    {
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
    }
}