using Navigation_WPF.Exceptions;
using Navigation_WPF.Models;
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
        protected override void OnStartup(StartupEventArgs e)
        {
            Hotel hotel = new Hotel("Hotel jorge jeje");

            try
            {
                hotel.MakeReservation(new Reservation(
                new RoomID(1, 3),
                "Jorge",
                new DateTime(2000, 1, 3),
                new DateTime(2000, 1, 4)));

                hotel.MakeReservation(new Reservation(
                    new RoomID(1, 3),
                    "Jorge",
                    new DateTime(2000, 1, 3),
                    new DateTime(2000, 1, 4)));
            }
            catch (ReservationConflictException ex)
            {

            }

            IEnumerable<Reservation> reservations = hotel.GetReservationsForUser("Jorge");
            base.OnStartup(e);
        }
    }
}
