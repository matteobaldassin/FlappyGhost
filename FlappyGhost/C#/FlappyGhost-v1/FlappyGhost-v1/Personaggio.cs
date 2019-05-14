using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlappyGhost_v1
{
    class Personaggio
    {
        private int dimensione;

        private int distanzaDaSuolo;

        private Punto centro;

        public Personaggio()
        {
            dimensione = 0;
            distanzaDaSuolo = 0;

        }
        /**
         * costruttore dove vengono passati i parametri e vengono creati gli oggetti sottostanti
         * @param dimensione
         * @param distanzaDaSuolo
         * @param centro 
         */
        public Personaggio(int dimensione, int distanzaDaSuolo, Punto centro)
        {
            this.dimensione = dimensione;
            this.distanzaDaSuolo = distanzaDaSuolo;
            this.centro = centro;
        }

        public int getDistanzaDaSuolo()
        {
            return distanzaDaSuolo;
        }

        public void setDistanzaDaSuolo(int distanzaDaSuolo)
        {
            this.distanzaDaSuolo = distanzaDaSuolo;
        }

        public Punto getCentro()
        {
            return centro;
        }

        public void setCentro(Punto centro)
        {
            this.centro = centro;
        }
        /**
         * imposta l'altezza del personaggio, riprendendo il valore passato
         * dalla porta seriale
         * @param valore valore passato dalla porta seriale
         * @return il valore della posizione sull'asse Y del fantasmino
         */
        public int setAltezza(int valore)
        {
            centro.setX(valore);
            return valore;
        }
    }
}
