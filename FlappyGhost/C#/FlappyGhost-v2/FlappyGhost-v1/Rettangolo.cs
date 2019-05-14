using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlappyGhost_v1
{
    class Rettangolo
    {
        private
            Punto altoSx;
        Punto bassoDx;
        /// <summary>
        /// Inizializza l'oggetto Rettangolo avendo in ingresso il Punto altoSx e il Punto bassoDx
        /// </summary>
        /// <param name="altoSx"></param>
        /// <param name="bassoDx"></param>
        public Rettangolo(Punto altoSx, Punto bassoDx)
        {
            this.altoSx = altoSx;
            this.bassoDx = bassoDx;
        }
        /// <summary>
        /// Costruttore di default
        /// </summary>
        public Rettangolo()
        {
            altoSx = new Punto(0, 0);
            bassoDx = new Punto(0, 0);
        }
        /// <summary>
        /// Ritorna il Punto altoSx
        /// </summary>
        /// <returns></returns>
        public Punto getAltoSx()
        {
            return altoSx;
        }
        /// <summary>
        /// Ritorna il punto bassoDx
        /// </summary>
        /// <returns></returns>
        public Punto getBassoDx()
        {
            return bassoDx;
        }
        /// <summary>
        /// Cambia il valore del punto altoSx con il valore ricevuto come parametro
        /// </summary>
        /// <param name="altoSx"></param>
        public void setAltoSx(Punto altoSx)
        {
            this.altoSx = altoSx;
        }
        /// <summary>
        /// Cambia il valore del punto bassoDx con il valore ricevuto come parametro
        /// </summary>
        /// <param name="bassoDx"></param>
        public void setBassoDx(Punto bassoDx)
        {
            this.bassoDx = bassoDx;
        }
    }

}
