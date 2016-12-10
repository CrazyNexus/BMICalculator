// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace BMICalculator
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		UIKit.UILabel bmiLabel { get; set; }

		[Outlet]
		UIKit.UIButton calculateButton { get; set; }

		[Outlet]
		UIKit.UITextField heightTextField { get; set; }

		[Outlet]
		UIKit.UITextField weightTextFiel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (bmiLabel != null) {
				bmiLabel.Dispose ();
				bmiLabel = null;
			}

			if (calculateButton != null) {
				calculateButton.Dispose ();
				calculateButton = null;
			}

			if (heightTextField != null) {
				heightTextField.Dispose ();
				heightTextField = null;
			}

			if (weightTextFiel != null) {
				weightTextFiel.Dispose ();
				weightTextFiel = null;
			}
		}
	}
}
