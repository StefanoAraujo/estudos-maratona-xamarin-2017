﻿using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer (typeof(ViewCell), typeof(EstudantesXamarinForms.iOS.CustomAllViewCellRendereriOS))]
namespace EstudantesXamarinForms.iOS
{
	public class CustomAllViewCellRendereriOS : ViewCellRenderer
	{
		public override UIKit.UITableViewCell GetCell(Cell item, UIKit.UITableViewCell reusableCell, UIKit.UITableView tv)
		{
			var cell = base.GetCell(item, reusableCell, tv);
			if (cell != null)
				cell.SelectionStyle = UIKit.UITableViewCellSelectionStyle.None;
			return cell;
		}
	}
}
