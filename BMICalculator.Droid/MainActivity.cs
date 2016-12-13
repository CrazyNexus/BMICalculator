using Android.App;
using Android.Widget;
using Android.OS;
using BMICalculator.Shared;

namespace BMICalculator.Droid
{
   [Activity(Label = "BMI Calculator", MainLauncher = true, Icon = "@mipmap/icon")]
   public class MainActivity : Activity
   {
      Button calculateButton;
      TextView resultTextView;
      EditText heightEditText, weightEditText;

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

         calculateButton.Click += CalculateButton_Click;
      }

      void CalculateButton_Click(object sender, System.EventArgs e)
      {
         float height = float.Parse(heightEditText.Text);
         float weight = float.Parse(weightEditText.Text);

         BMICalc calc = new BMICalc(weight, height);
         float bmi = calc.getBMI();

         resultTextView.Text = bmi.ToString();
      }
   }
}

