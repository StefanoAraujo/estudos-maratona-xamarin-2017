using Android.App;
using Android.Widget;
using Android.OS;

namespace XelloXamarinAndroid
{
    [Activity(Label = "XelloXamarinAndroid", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

            Button b = FindViewById<Button>(Resource.Id.button1);

            b.Click += delegate
            {
                b.Text = string.Format("{0} clicks", count++);
            };
        }
    }
}

