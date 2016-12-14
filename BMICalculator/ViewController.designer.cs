// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
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

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnDetails { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (bmiLabel != null) {
                bmiLabel.Dispose ();
                bmiLabel = null;
            }

            if (btnDetails != null) {
                btnDetails.Dispose ();
                btnDetails = null;
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