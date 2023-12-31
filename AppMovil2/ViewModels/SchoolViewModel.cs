﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace AppMovil2.ViewModels
{
    class SchoolViewModel : BaseViewModel
    {
        public SchoolViewModel()
        {
            Title = "Universidad";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://utt.edu.mx/"));
        }

        public ICommand OpenWebCommand { get; }
    }
}
