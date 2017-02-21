using System;

using Xamarin.Forms;

namespace MinhasTarefas
{
	public partial class MinhasTarefasItemPage : ContentPage
	{
		public MinhasTarefasItemPage()
		{
			InitializeComponent();
		}

		async void OnSaveClicked(object sender, EventArgs e)
		{
			var tarefa = (Tarefa)BindingContext;
			await App.TarefasRepository.SaveItemAsync(tarefa);
			await Navigation.PopAsync();
		}

		async void OnDeleteClicked(object sender, EventArgs e)
		{
			var tarefa = (Tarefa)BindingContext;
			await App.TarefasRepository.DeleteItemAsync(tarefa);
			await Navigation.PopAsync();
		}

		async void OnCancelClicked(object sender, EventArgs e)
		{
			await Navigation.PopAsync();
		}

		void OnSpeakClicked(object sender, EventArgs e)
		{
			var tarefa = (Tarefa)BindingContext;
			DependencyService.Get<ITextToSpeech>().Speak(tarefa.Titulo + " " + tarefa.Notas);
		}
	}
}
