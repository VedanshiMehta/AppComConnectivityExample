using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;

namespace AppComConnectivityExample
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        Button myAppTheme;
        Button myCompass;
        Button myConnectivity;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);


            myAppTheme = FindViewById<Button>(Resource.Id.button1);
            myCompass = FindViewById<Button>(Resource.Id.button2);
            myConnectivity = FindViewById<Button>(Resource.Id.button3);


            myAppTheme.Click += MyAppTheme_Click;
            myCompass.Click += MyCompass_Click;
            myConnectivity.Click += MyConnectivity_Click;
        }

        private void MyConnectivity_Click(object sender, System.EventArgs e)
        {
            Intent k = new Intent(Application.Context, typeof(MyConnectivity));
            StartActivity(k);
        }

        private void MyCompass_Click(object sender, System.EventArgs e)
        {

            Intent j = new Intent(Application.Context, typeof(MyCompass));
            StartActivity(j);
        }

        private void MyAppTheme_Click(object sender, System.EventArgs e)
        {
            Intent i = new Intent(Application.Context, typeof(MyAppTheme));
            StartActivity(i);
        }

        private void MyPropertyDemo_Click(object sender, System.EventArgs e)
        {
        
        }

      

        

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}