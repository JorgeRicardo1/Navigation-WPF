using Navigation_WPF.Exceptions;
using Navigation_WPF.Models;
using Navigation_WPF.Services;
using Navigation_WPF.Stores;
using Navigation_WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Navigation_WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly Hotel _hotel;
        private readonly NavigationStore _navigationStore;

        public App()
        {
            _hotel = new Hotel("Hotel jorge");
            _navigationStore = new NavigationStore();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            _navigationStore.CurrentViewModel = CreateReservationViewModel();
            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_navigationStore)
            };
            MainWindow.Show();
            base.OnStartup(e);
        }

        private MakeReservationViewModel CreateMakeReservationViewModel()
        {
            return new MakeReservationViewModel(_hotel,new NavigationServices(_navigationStore, CreateReservationViewModel));
        }

        private ReservationListingViewModel CreateReservationViewModel()
        {
            return new ReservationListingViewModel(_hotel,new NavigationServices(_navigationStore, CreateMakeReservationViewModel));
        }
    }
}
