using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlappyGhost_v1
{
    class Punto
    {

        private int x;
        private int y;

        /// <summary>
        /// Inizializza l'oggetto Punto avendo in ingresso le coordinate
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Punto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        /// <summary>
        /// Cambia il valore di Y
        /// </summary>
        /// <param name="y"></param>
        public void setY(int y)
        {
            this.y = y;
        }
        /// <summary>
        /// Cambia il valore di X
        /// </summary>
        /// <param name="x"></param>
        public void setX(int x)
        {
            this.x = x;
        }



    }
}
