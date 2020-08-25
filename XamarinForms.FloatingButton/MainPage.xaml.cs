﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinForms.FloatingButton
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ButtonNavigateToListPage_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new ListPage());
        }
    }
}
