using Foundation;
using System;
using UIKit;
using BMICalculator.Shared;

namespace BMICalculator
{
   public partial class DetailViewController : UIViewController
   {
      public BMICalc bmiCalc;

      public DetailViewController(IntPtr handle) : base(handle)
      {
      }

      public override void ViewDidLoad()
      {
         base.ViewDidLoad();
         lbDetailText.Text = bmiCalc.getBMIDetail();
      }
   }
}