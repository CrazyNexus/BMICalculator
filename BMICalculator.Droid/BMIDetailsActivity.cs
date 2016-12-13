
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
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// create a nuew content view
			SetContentView(Resource.Layout.BMIDetails);


		}
	}
}
