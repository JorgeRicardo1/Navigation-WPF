﻿using Navigation_WPF.Commands;
using Navigation_WPF.Models;
using Navigation_WPF.Services;
using Navigation_WPF.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Navigation_WPF.ViewModels
{
    public class MakeReservationViewModel : ViewModelBase
    {
        private string _username;
        public string UserName
        {
            get
            {
                return _username;
            }
            set
            {
                _username = value;
                OnPropertyChanged(nameof(UserName));
            }
        }

        private int _floorNumber;
        public int FloorNumber
        {
            get
            {
                return _floorNumber;
            }
            set
            {
                _floorNumber = value;
                OnPropertyChanged(nameof(FloorNumber));
            }
        }

        private int _roomNumber;
        public int RoomNumber
        {
            get
            {
                return _roomNumber;
            }
            set
            {
                _roomNumber = value;
                OnPropertyChanged(nameof(RoomNumber));
            }
        }

        private DateTime _startDate = new DateTime(2023, 1, 1);
        public DateTime StartDate
        {
            get
            {
                return _startDate;
            }
            set
            {
                _startDate = value;
                OnPropertyChanged(nameof(StartDate));
            }
        }

        private DateTime _endDate = new DateTime(2023, 8, 1);
        public DateTime EndDate
        {
            get
            {
                return _endDate;
            }
            set
            {
                _endDate = value;
                OnPropertyChanged(nameof(EndDate));
            }
        }

        public ICommand SubmitCommand { get;}
        public ICommand CancelCommand { get; }

        public MakeReservationViewModel(Hotel hotel, NavigationServices reservationViewNavigationServices)
        {
            SubmitCommand = new MakeReservationCommand(this, hotel, reservationViewNavigationServices);
            CancelCommand = new NavigateCommand(reservationViewNavigationServices);
        }
    }
}
