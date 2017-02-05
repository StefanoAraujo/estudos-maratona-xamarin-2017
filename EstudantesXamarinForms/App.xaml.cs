using Xamarin.Forms;

namespace EstudantesXamarinForms
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new NavigationPage(new ListaEstudantesPage())
			{ 
				BarBackgroundColor = Color.FromRgb(32,124,195),
				BarTextColor = Color.White,

			};
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
