using Android.App;
using Android.Widget;
using Android.OS;
using BMICalculator.Shared;
using Android.Content;

namespace BMICalculator.Droid
{
   [Activity(Label = "BMI Calculator", MainLauncher = true, Icon = "@mipmap/icon")]
   public class MainActivity : Activity
   {
      Button calculateButton, bmiDetailButton;
      TextView resultTextView;
      EditText heightEditText, weightEditText;

      float bmi = 20.0f;

      protected override void OnCreate(Bundle savedInstanceState)
      {
         base.OnCreate(savedInstanceState);

         // Set our view from the "main" layout resource
         SetContentView(Resource.Layout.Main);

         // find and assign view elements 
         calculateButton = FindViewById<Button>(BMICalculator.Droid.Resource.Id.calculateButton);
         resultTextView = FindViewById<TextView>(BMICalculator.Droid.Resource.Id.resultTextView);
         heightEditText = FindViewById<EditText>(BMICalculator.Droid.Resource.Id.heightEditText);
         weightEditText = FindViewById<EditText>(BMICalculator.Droid.Resource.Id.weigthEditText);
         bmiDetailButton = FindViewById<Button>(Resource.Id.showDetailsButton);

         calculateButton.Click += CalculateButton_Click;
         bmiDetailButton.Click += BmiDetailButton_Click;
      }

      void CalculateButton_Click(object sender, System.EventArgs e)
      {
         float height = float.Parse(heightEditText.Text);
         float weight = float.Parse(weightEditText.Text);

         BMICalc calc = new BMICalc(weight, height);
         bmi = calc.getBMI();

         resultTextView.Text = bmi.ToString();
      }

      void BmiDetailButton_Click(object sender, System.EventArgs e)
      {
         var intent = new Intent(this, typeof(BMIDetailsActivity));
         intent.PutExtra("bmiValue", bmi);
         StartActivity(intent);
      }
   }
}

