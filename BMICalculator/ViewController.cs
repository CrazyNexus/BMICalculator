using System;
using BMICalculator.Shared;

using UIKit;
using Foundation;

namespace BMICalculator
{
   public partial class ViewController : UIViewController
   {
      float bmi = 0.0f;
      BMICalc bmiCalc;

      protected ViewController(IntPtr handle) : base(handle)
      {
         // Note: this .ctor should not contain any initialization logic.
      }

      public override void ViewDidLoad()
      {
         base.ViewDidLoad();

         calculateButton.TouchUpInside += CalculateButton_TouchUpInside;
      }

      public override void DidReceiveMemoryWarning()
      {
         base.DidReceiveMemoryWarning();
         // Release any cached data, images, etc that aren't in use.
      }

      void CalculateButton_TouchUpInside(object sender, EventArgs e)
      {
         float height = float.Parse(heightTextField.Text);
         float weight = float.Parse(weightTextFiel.Text);

         bmiCalc = new BMICalc(weight, height);
         bmi = bmiCalc.getBMI();

         bmiLabel.Text = bmi.ToString();

         heightTextField.ResignFirstResponder();
         weightTextFiel.ResignFirstResponder();
      }

      public override void TouchesBegan(NSSet touches, UIEvent evt)
      {
         base.TouchesBegan(touches, evt);

         this.View.EndEditing(true);
      }

      public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
      {
         base.PrepareForSegue(segue, sender);

         if (segue.Identifier == "showDetail")
         {
            var controller = segue.DestinationViewController as DetailViewController;
            controller.bmiCalc = bmiCalc;
         }
      }
   }
}
