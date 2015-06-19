
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

namespace XamGraveAdmin
{
	[Activity (Label = "GraveActivity")]			
	public class GraveActivity : Activity
	{
		TextView txtview;
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			// Create your application here
			txtview = new TextView(this);
			txtview.Text = "Graven toch!";
			SetContentView (txtview);
		}
	}
}

