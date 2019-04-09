﻿using System;
using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using CarouselView.FormsPlugin.Android;
using App4;

namespace Awesomekit.Droid
{
    [Activity(Theme = "@style/MainTheme", ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            
            base.OnCreate(bundle);
            InitControls();

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());
        }

        private void InitControls()
        {
            CarouselViewRenderer.Init();
        }
    }
}
