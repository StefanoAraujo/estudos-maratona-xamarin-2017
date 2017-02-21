using System.ComponentModel;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(ViewCell), typeof(MinhasTarefas.iOS.CustomAllViewCellRendereriOS))]
namespace MinhasTarefas.iOS
{
	public class CustomAllViewCellRendereriOS : ViewCellRenderer
	{
		public override UITableViewCell GetCell(Cell item, UIKit.UITableViewCell reusableCell, UIKit.UITableView tv)
		{
			var cell = base.GetCell(item, reusableCell, tv);
			if (cell != null)
				cell.SelectionStyle = UITableViewCellSelectionStyle.Blue;
			return cell;
		}
	}
}
