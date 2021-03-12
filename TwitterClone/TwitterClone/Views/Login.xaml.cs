﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitterClone.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TwitterClone.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
            this.BindingContext = new LoginViewModel();
        }
    }
}