using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EstudantesXamarinForms
{
	public partial class ListaEstudantesPage : ContentPage
	{
		public ListaEstudantesPage()
		{
			InitializeComponent();
			estudantesListView.ItemsSource = EstudanteServices.Get();
		}


		void Handle_ItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			var estudante = e.SelectedItem as EstudanteModel;
			DisplayAlert("Estudante selecionado:", estudante.Nome, "OK");
		}


		void Handle_DeleteClicked(object sender, System.EventArgs e)
		{
			var mi = ((MenuItem)sender);
			var estudante = mi.CommandParameter as EstudanteModel;

			DisplayAlert("Remover", "Deseja realmente remover o estudante: " + estudante.Nome + "?", "OK", "Cancelar")
			.ContinueWith(t => {
				if (t.Result)
				{
					// REMOVE O ITEM SELECIONADO!
					estudantesListView.ItemsSource = EstudanteServices.Delete(estudante);
				}
			}, TaskContinuationOptions.ExecuteSynchronously);

		}


		void Handle_Refreshing(object sender, System.EventArgs e)
		{
			// RECARREGA TODOS OS ITENS NOVAMENTE!
			estudantesListView.ItemsSource = EstudanteServices.Get();

			var listView = sender as ListView;
			listView.EndRefresh();
		}
	}
}
