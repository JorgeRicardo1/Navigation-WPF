using Navigation_WPF.Services;
using Navigation_WPF.Stores;
using Navigation_WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navigation_WPF.Commands
{
    public class NavigateCommand : CommandBase
    {
        private readonly NavigationServices _navigationServices;

        public NavigateCommand(NavigationServices navigationServices)
        {
            _navigationServices = navigationServices;
        }


        public override void Execute(object? parameter)
        {
            _navigationServices.Navigate();
        }
    }
}
