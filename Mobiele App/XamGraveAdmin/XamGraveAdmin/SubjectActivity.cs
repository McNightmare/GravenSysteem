
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
	[Activity (Label = "SubjectActivity")]			
	public class SubjectActivity : Activity
	{
        ScrollView scrollSearch;
        LinearLayout layoutSearch;
        private string[] fields;
        private TextView[] txtTitle;
        private EditText[] edField;
        private ArrayAdapter adapter;
        public Spinner spnType;
        public Button btnSearch;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			// Create your application here
			SetContentView (Resource.Layout.search);

            scrollSearch = FindViewById<ScrollView>(Resource.Id.scrollSearch);
            layoutSearch = FindViewById<LinearLayout>(Resource.Id.layoutSearch);

            fields = new string[] { "Postcode", "Huisnummer", "Straat", "Geboortedatum", "Naam", "Begraafplaats", "Overlijdensdatum", "BNS/Sofi-nummer", "A-nummer", "Subject code", "Soorten" };
            txtTitle = new TextView[fields.Length];
            edField = new EditText[fields.Length];
            CreateLayout();

            spnType = new Spinner(this);
            adapter = ArrayAdapter.CreateFromResource(this, Resource.Array.subjectArray, Android.Resource.Layout.SimpleSpinnerItem);
            adapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            spnType.Adapter = adapter;

            btnSearch = new Button(this);
            btnSearch.Text = Resources.GetString(Resource.String.search_button);

            SetLayout(0);

            spnType.ItemSelected += (sender, e) =>
           {
               SetLayout(e.Position);
           };
        }

        public void CreateLayout()
        {
            for (int i = 0; i < fields.Length; i++)
            {
                txtTitle[i] = new TextView(this);
                txtTitle[i].Text = fields[i];
                edField[i] = new EditText(this);
                if (fields[i].Contains("nummer"))
                    edField[i].InputType = Android.Text.InputTypes.NumberVariationNormal;
                else if (fields[i].Contains("datum"))
                    edField[i].InputType = Android.Text.InputTypes.DatetimeVariationDate;
                else if (fields[i].Contains("post"))
                    edField[i].InputType = Android.Text.InputTypes.TextVariationPostalAddress;
                else if (fields[i].Contains("naam"))
                    edField[i].InputType = Android.Text.InputTypes.TextVariationPersonName;
                else
                    edField[i].InputType = Android.Text.InputTypes.TextVariationNormal;
            }
		}
        private void SetLayout(int pos)
        {
            layoutSearch.RemoveAllViews();
            layoutSearch.AddView(spnType);
            for (int i = 0; i < fields.Length; i++)
            {
                switch (pos)
                {
                    case 0:
                        if (fields[i].Contains("post") || fields[i].Contains("huis"))
                        {
                            layoutSearch.AddView(txtTitle[i]);
                            layoutSearch.AddView(edField[i]);
                        }
                        break;
                    case 1:
                        if (fields[i].Contains("straat") || fields[i].Contains("huis"))
                        {
                            layoutSearch.AddView(txtTitle[i]);
                            layoutSearch.AddView(edField[i]);
                        }
                        break;
                    case 2:
                        if (fields[i].Contains("geboorte") || fields[i].Contains("naam"))
                        {
                            layoutSearch.AddView(txtTitle[i]);
                            layoutSearch.AddView(edField[i]);
                        }
                        break;
                    case 3:
                        if (fields[i].Contains("begraaf") || fields[i].Contains("overledene") || fields[i].Contains("naam"))
                        {
                            layoutSearch.AddView(txtTitle[i]);
                            layoutSearch.AddView(edField[i]);
                        }
                        break;
                    case 4:
                        if (fields[i].Contains("naam") || fields[i].Contains("straat"))
                        {
                            layoutSearch.AddView(txtTitle[i]);
                            layoutSearch.AddView(edField[i]);
                        }
                        break;
                    case 5:
                        if (fields[i].Contains("bns"))
                        {
                            layoutSearch.AddView(txtTitle[i]);
                            layoutSearch.AddView(edField[i]);
                        }
                        break;
                    case 6:
                        if (fields[i].Contains("a-nummer"))
                        {
                            layoutSearch.AddView(txtTitle[i]);
                            layoutSearch.AddView(edField[i]);
                        }
                        break;
                    case 7:
                        if (fields[i].Contains("subject"))
                        {
                            layoutSearch.AddView(txtTitle[i]);
                            layoutSearch.AddView(edField[i]);
                        }
                        break;
                    case 8:
                        layoutSearch.AddView(txtTitle[i]);
                        layoutSearch.AddView(edField[i]);
                        break;
                }
            }
            layoutSearch.AddView(btnSearch);
        }
	}
}

