using Navigation_WPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navigation_WPF.ViewModels
{
    public class ReservationViewModel : ViewModelBase
    {
        private Reservation _reservation;

        public string RoomID => _reservation.RoomID?.ToString();
        public string Username => _reservation.Username;
        public string StartTime => _reservation.StartTime.ToString("d");
        public string EndTime => _reservation.EndTime.ToString("d");

        public ReservationViewModel(Reservation reservation)
        {
            _reservation = reservation;
        }
    }
}
