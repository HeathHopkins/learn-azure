﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Yammerly.Helpers;
using Yammerly.Views;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Yammerly
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            if (Settings.LoggedIn)
                MainPage = new RootPage();
            else
                MainPage = new LoginPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
