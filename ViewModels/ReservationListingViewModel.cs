using Navigation_WPF.Commands;
using Navigation_WPF.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Navigation_WPF.ViewModels
{
    class ReservationListingViewModel : ViewModelBase
    {
        private readonly ObservableCollection<ReservationViewModel> _reservations;
        public IEnumerable<ReservationViewModel> Reservations => _reservations;
        public ICommand MakeReservationCommand { get;}

        public ReservationListingViewModel()
        {
            _reservations = new ObservableCollection<ReservationViewModel>();
            MakeReservationCommand = new NavigateCommand();

            _reservations.Add(new ReservationViewModel(
                new Reservation(new RoomID(1, 2), "JOrge", DateTime.Now, DateTime.Now)
                ));
            _reservations.Add(new ReservationViewModel(
                new Reservation(new RoomID(1, 3), "Pedro", DateTime.Now, DateTime.Now)
                ));
            _reservations.Add(new ReservationViewModel(
                new Reservation(new RoomID(1, 4), "Carlos", DateTime.Now, DateTime.Now)
                ));
        }
    }
}
