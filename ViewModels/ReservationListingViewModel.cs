using Navigation_WPF.Commands;
using Navigation_WPF.Models;
using Navigation_WPF.Services;
using Navigation_WPF.Stores;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Navigation_WPF.ViewModels
{
    public class ReservationListingViewModel : ViewModelBase
    {
        private readonly ObservableCollection<ReservationViewModel> _reservations;
        private readonly Hotel _hotel;

        public IEnumerable<ReservationViewModel> Reservations => _reservations;
        public ICommand MakeReservationCommand { get;}

        public ReservationListingViewModel(Hotel hotel, NavigationServices MakeReservationNavigationServices)
        {
            _reservations = new ObservableCollection<ReservationViewModel>();
            _hotel = hotel;

            MakeReservationCommand = new NavigateCommand(MakeReservationNavigationServices);

            UpdateReservations();
        }

        private void UpdateReservations()
        {
            _reservations.Clear();

            foreach (Reservation reservation in _hotel.GetAllReservations())
            {
                ReservationViewModel reservationViewModel = new ReservationViewModel(reservation);
                _reservations.Add(reservationViewModel);
            }
        }
    }
}
