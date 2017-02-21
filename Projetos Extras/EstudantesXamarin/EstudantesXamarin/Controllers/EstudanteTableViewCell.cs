using System;

using Foundation;
using UIKit;

namespace EstudantesXamarin
{
	public partial class EstudanteTableViewCell : UITableViewCell
	{
		public static readonly NSString Key = new NSString("EstudanteTableViewCell");
		public static readonly UINib Nib;

		static EstudanteTableViewCell()
		{
			Nib = UINib.FromName("EstudanteTableViewCell", NSBundle.MainBundle);
		}

		protected EstudanteTableViewCell(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}
	}
}
