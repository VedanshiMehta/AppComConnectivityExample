using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Essentials;

namespace AppComConnectivityExample
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme")]
    class MyAppTheme : Activity
    {
        private TextView myText;
        private Button button;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.AppThemeDemo);
            UIRefrence();
            UIClickEvents();
        }

        private void UIClickEvents()
        {
            button.Click += Button_Click;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            var currTheme = AppInfo.RequestedTheme;
            myText.Text = $"CurrentTheme:{currTheme}";
        }

        private void UIRefrence()
        {
            button = FindViewById<Button>(Resource.Id.buttonAP);
            myText = FindViewById<TextView>(Resource.Id.textViewAP);
        }
    }
}