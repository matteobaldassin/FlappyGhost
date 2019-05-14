using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlappyGhost_v1
{
    class Ostacolo
    {
        private Rettangolo ostacolo1;

        private Rettangolo ostacolo2;

        public Ostacolo(Rettangolo rett1, Rettangolo rett2)
        {
            this.rett1 = ostacolo1;
            this.rett2 = ostacolo2;
        }

        public Ostacolo()
        {
            ostacolo1 = new Rettangolo();
            ostacolo2 = new Rettangolo();
        }

        public Rettangolo getostacolo1()
        {
            return ostacolo1;
        }

        public void setostacolo1(Rettangolo ostacolo1)
        {
            this.ostacolo1 = ostacolo1;
        }

        public Rettangolo getostacolo2()
        {
            return ostacolo2;
        }

        public void setostacolo2(Rettangolo ostacolo2)
        {
            this.ostacolo2 = ostacolo2;
        }

        ///  riceve un personaggio in pers e restituisce true se pers 
        ///si sovrappone a rettangolo1 o rettangolo2.Altrimenti restituisce false
        /// <param name="pers">personaggio da controllare
        /// <returns>booleano che indica se il personaggio HA colpito 
        public bool colpito(Personaggio pers)
        {
        }

        /// metodo che serve per disegnare gli ostacoli in modo 
        /// randomico all' interno della mappa,non ha nulla come 
        ///parametro e non restituisce alcun valore in quanto disegna direttamente gli ostacoli 
        public void disegna()
        {
            Punto
        }



    }
}
