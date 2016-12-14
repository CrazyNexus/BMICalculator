
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace BMICalculator.Droid
{
   [Activity(Label = "BMIDetailsActivity")]
   public class BMIDetailsActivity : Activity
   {
      TextView detailTextView;

      protected override void OnCreate(Bundle savedInstanceState)
      {
         base.OnCreate(savedInstanceState);

         SetContentView(Resource.Layout.BMIDetails);
         detailTextView = FindViewById<TextView>(Resource.Id.bmiDetailTextView);

         var bmi = Intent.Extras.GetFloat("bmiValue");
         EvaluateBMI(bmi);
      }

      void EvaluateBMI(float bmi)
      {
         string result = string.Empty;

         if (bmi <= 16)
            result = "sehr niedrig";
         else if (bmi < 18.5)
            result = "niedrig";
         else if (bmi < 25)
            result = "normal";
         else if (bmi < 30)
            result = "hoch";
         else
            result = "zu hoch";

         detailTextView.Text = result;
      }
   }
}
