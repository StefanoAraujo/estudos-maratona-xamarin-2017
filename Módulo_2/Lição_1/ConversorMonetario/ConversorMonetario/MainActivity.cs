using Android.App;
using Android.Widget;
using Android.OS;

namespace ConversorMonetario
{
    [Activity(Label = "ConversorMonetario", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

            var btnCalc = FindViewById<Button>(Resource.Id.btnCalcular);
            var txtDolar = FindViewById<EditText>(Resource.Id.txtDolar);
            var txtReal = FindViewById<EditText>(Resource.Id.txtReal);

            //double real, dolar;

            btnCalc.Click += delegate
            {
                try
                {
                    //dolar = double.Parse(txtDolar.Text);
                    //real = dolar * 3.126;
                    txtReal.Text = (double.Parse(txtDolar.Text) * 3.126).ToString();
                }
                catch (System.Exception ex)
                {
                    Toast.MakeText(this, ex.Message, ToastLength.Short).Show();
                }
            };
        }
    }
}

