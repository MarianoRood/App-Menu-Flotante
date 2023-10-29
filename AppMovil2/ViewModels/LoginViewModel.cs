using AppMovil2.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace AppMovil2.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public Command LoginCommand { get; }

        public LoginViewModel()
        {
            //LoginCommand = new Command(OnLoginClicked);
        }
    }
}
