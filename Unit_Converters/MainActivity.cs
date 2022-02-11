using Android.App;
using Android.OS;
using Android.Runtime;
using AndroidX.AppCompat.App;
using Android.Widget;
using Xamarin.Essentials;
using System;

namespace Unit_Converters
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        TextView faentocel,kilotomiles,degreetoradians,kilogramstopounds;
        EditText input;
        Button calculate1;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            input = FindViewById<EditText>(Resource.Id.userEdit);
            calculate1 = FindViewById<Button>(Resource.Id.calc);
            kilotomiles = FindViewById<TextView>(Resource.Id.kilometerstomiles);
            faentocel = FindViewById<TextView>(Resource.Id.farenhiettocelcius);
            degreetoradians = FindViewById<TextView>(Resource.Id.degreetoradians);
            kilogramstopounds = FindViewById<TextView>(Resource.Id.kilogramstopound);
            calculate1.Click += Calculate1_Click;
        }

        private void Calculate1_Click(object sender, System.EventArgs e)
        {
            int userinput = Convert.ToInt32(input.Text);
            faentocel.Text = $"Farenhiet to celcius:{UnitConverters.FahrenheitToCelsius(userinput)}";
            degreetoradians.Text = $"Degree to Radians:{UnitConverters.DegreesToRadians(userinput)}";
            kilogramstopounds.Text = $"kilograms to pounds:{UnitConverters.KilogramsToPounds(userinput)}";
            kilotomiles.Text = $"Kilometers to Miles:{UnitConverters.KilometersToMiles(userinput)}";
        }

      
    }
}