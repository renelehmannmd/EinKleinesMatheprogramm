using EinKleinesMatheprogramm.MathematischeKlassen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EinKleinesMatheprogramm.ViewModels
{
    public class BruchrechnungViewModel : ViewModelBasis
    {
        private string bruchA;
        private string bruchB;
         
        public string BruchA
        {
            get => bruchA;
            set
            {
                SetProperty(ref bruchA, value);
            }
        }

        public string BruchB
        {
            get => bruchB;
            set
            {
                SetProperty(ref bruchB, value);
            }
        }

        private Bruch ersterBruch;
        public Bruch ErsterBruch
        {
            get => ersterBruch;
            set => SetProperty(ref ersterBruch, value);
        }

        private Bruch zweiterBruch;
        public Bruch ZweiterBruch
        {
            get => zweiterBruch;
            set => SetProperty(ref zweiterBruch, value);
        }

        public BruchrechnungViewModel()
        {

        }

    }
}
