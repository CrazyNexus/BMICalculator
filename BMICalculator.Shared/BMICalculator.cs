using System;
namespace BMICalculator.Shared
{
   public class BMICalc
   {
      float weight;
      float height;

      public BMICalc(float weight, float height)
      {
         this.height = height;
         this.weight = weight;
      }

      public float getBMI()
      {
         return (weight / (height * height));
      }

      public string getBMIDetail()
      {
         float bmi = getBMI();
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

         return result;
      }
   }
}
