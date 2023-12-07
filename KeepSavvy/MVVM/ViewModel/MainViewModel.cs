using System;
using System.Windows;
using KeepSavvy.Core;

namespace KeepSavvy.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        // to bind with radio button
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand AddViewCommand { get; set; }
        public RelayCommand DispatchViewCommand { get; set; }
        public RelayCommand ModifyViewCommand { get; set; }
        public RelayCommand RemoveViewCommand { get; set; }
        public RelayCommand ReturnViewCommand { get; set; }

        // view page models
        public HomeViewModel HomeVM { get; set; }
        public AddViewModel AddVM { get; set; }
        public DispatchViewModel DispatchVM { get; set; }
        public ModifyViewModel ModifyVM { get; set; }
        public RemoveViewModel RemoveVM { get; set; }
        public ReturnViewModel ReturnVM { get; set; }

        // function to change View
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

        // main function
        public MainViewModel()
        {
            // instance of view file
            HomeVM = new HomeViewModel();
            AddVM = new AddViewModel();
            DispatchVM = new DispatchViewModel();
            ModifyVM = new ModifyViewModel();
            RemoveVM = new RemoveViewModel();
            ReturnVM = new ReturnViewModel();

            // launch main home view
            CurrentView = HomeVM;

            // change betwen views
            HomeViewCommand = new RelayCommand(o => {CurrentView = HomeVM;});
            AddViewCommand = new RelayCommand(o => {CurrentView = AddVM;});
            DispatchViewCommand = new RelayCommand(o => {CurrentView = DispatchVM;});
            ModifyViewCommand = new RelayCommand(o => {CurrentView = ModifyVM;});
            RemoveViewCommand = new RelayCommand(o => {CurrentView = RemoveVM;});
            ReturnViewCommand = new RelayCommand(o => {CurrentView = ReturnVM;});


        }

    }
}
