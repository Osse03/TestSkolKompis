using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using TestSkolKompis.Core;

namespace TestSkolKompis.MVVM.ViewModel
{

    internal class MainViewModel : ObservableObject
    {

        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand MinProfilViewCommand { get; set; }
        public HomeViewModel HomeVm { get; set; }

        public MinProfilViewModel MinProfilVM { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }


        public MainViewModel()
        {
            HomeVm = new HomeViewModel();
            MinProfilVM = new MinProfilViewModel();
            CurrentView = HomeVm;

            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVm;
            });

            MinProfilViewCommand = new RelayCommand(o =>
            {
                CurrentView = MinProfilVM;
            });
        }
    }
}
