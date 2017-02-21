using System;
using System.Diagnostics;
using Xamarin.Forms;

namespace MinhasTarefas
{
	public partial class MinhasTarefasPage : ContentPage
	{
		public MinhasTarefasPage()
		{
			InitializeComponent();
		}


		protected override async void OnAppearing()
		{
			base.OnAppearing();

			// Reset the 'resume' id, since we just want to re-start here
			((App)Application.Current).ResumeAtTodoId = new Guid();

			tarefasListView.ItemsSource = await App.TarefasRepository.GetItemsAsync();
		}

		async void OnItemAdded(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new MinhasTarefasItemPage
			{
				BindingContext = new Tarefa()
			});
		}

		async void OnListItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			((App)Application.Current).ResumeAtTodoId = (e.SelectedItem as Tarefa).ID;
			Debug.WriteLine("setting ResumeAtTodoId = " + (e.SelectedItem as Tarefa).ID);

			await Navigation.PushAsync(new MinhasTarefasItemPage
			{
				BindingContext = e.SelectedItem as Tarefa
			});
		}
	}
}
