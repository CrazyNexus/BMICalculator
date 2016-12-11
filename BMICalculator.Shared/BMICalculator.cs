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
   }
}
