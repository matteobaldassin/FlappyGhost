using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyGhost_v1
{
    class Personaggio:PictureBox
    {
        private int dimensione;

        private int distanzaDaSuolo;

        private Punto centro;
        private int velocita { get; set; }

        public Personaggio():base()
        {
            dimensione = 0;
            distanzaDaSuolo = 0;
            velocita = 10;
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
        public void sposta(Keys tasto)
        {
            System.Drawing.Point pt = this.Location;

            if (tasto == Keys.Up)
                pt.Y -= velocita;
            else if (tasto == Keys.Down)
                pt.Y += velocita;
            else if (tasto == Keys.Right)
                pt.X += velocita;
            else if (tasto == Keys.Left)
                pt.X -= velocita;

            this.Location = pt;

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
        public bool scontrato(PictureBox bird)
        {
            bool ris = false;
            ris = this.Bounds.IntersectsWith(bird.Bounds);
            return ris;

        }
    }
}
