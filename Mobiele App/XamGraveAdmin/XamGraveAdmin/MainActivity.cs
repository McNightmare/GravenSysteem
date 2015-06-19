using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace XamGraveAdmin
{
	[Activity (Label = "Grave Admin", Icon = "@drawable/icon")]
	public class MainActivity : TabActivity
	{

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			// Set our view from the "main" layout resource
			RequestWindowFeature(WindowFeatures.NoTitle);
			SetContentView (Resource.Layout.Main);

			CreateTab(typeof(SubjectActivity), "subject", "Subject");
			CreateTab (typeof(GraveActivity), "grave", "Graven");
			CreateTab (typeof(DeceasedActivity), "deceased", "Overledene");
		}
		private void CreateTab(Type activityType, string tag, string label)
		{
			Intent intent = new Intent(this, activityType);
			intent.AddFlags(ActivityFlags.NewTask);

			TabHost.TabSpec spec = TabHost.NewTabSpec(tag);
			spec.SetIndicator(label);
			spec.SetContent(intent);

			TabHost.AddTab(spec);
		}
	}
}