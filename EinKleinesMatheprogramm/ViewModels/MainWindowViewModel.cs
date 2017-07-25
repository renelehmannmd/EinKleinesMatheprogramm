using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EinKleinesMatheprogramm.ViewModels
{
    public class MainWindowViewModel : ViewModelBasis
    {
        private BruchrechnungViewModel bruchrechnungsVM = new BruchrechnungViewModel();

        private ViewModelBasis aktivesViewModel = new ViewModelBasis();

        public ViewModelBasis AktivesViewModel
        {
            get => aktivesViewModel;
            set
            {
                SetProperty(ref aktivesViewModel, value);
            }
        }

        public MainWindowViewModel()
        {
            AktivesViewModel = bruchrechnungsVM;
        }

        
    }
}
