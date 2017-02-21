using System;
using System.ComponentModel;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(ListView), typeof(MinhasTarefas.iOS.CustomListViewRendereriOS))]
namespace MinhasTarefas.iOS
{
	public class CustomListViewRendereriOS : ListViewRenderer
	{
		protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			base.OnElementPropertyChanged(sender, e);

			if (Control == null)
			{
				return;
			}

			if (e.PropertyName == "ItemsSource")
			{
				foreach (var cell in Control.VisibleCells)
				{
					cell.SelectionStyle = UITableViewCellSelectionStyle.Blue;
				}
			}
		}
	}
}
