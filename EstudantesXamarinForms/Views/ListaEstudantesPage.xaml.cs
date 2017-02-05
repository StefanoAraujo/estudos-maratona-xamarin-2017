using System;
using System.Collections.Generic;

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
	}
}
