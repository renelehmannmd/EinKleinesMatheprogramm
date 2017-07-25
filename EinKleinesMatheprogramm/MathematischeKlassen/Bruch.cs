using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EinKleinesMatheprogramm.MathematischeKlassen
{
    public class Bruch
    {
        #region Felder
        private long zaehler;
        private long nenner;
        #endregion

        #region Properties
        public long Zaehler
        {
            get => zaehler;
            set => zaehler = value;
        }

        public long Nenner
        {
            get => nenner;
            set => nenner = value == 0 ? 1 : value;
        }

        #endregion

        #region Konstruktoren
        public Bruch() : this (0, 1) { }

        public Bruch(long z, long n)
        {
            zaehler = z;
            nenner = n;
        }

        #endregion

        #region Öffentliche Methoden
        #endregion

        #region Operatorüberladungen



        #endregion

        #region Private Hilfsmethoden
        #endregion
    }
}
