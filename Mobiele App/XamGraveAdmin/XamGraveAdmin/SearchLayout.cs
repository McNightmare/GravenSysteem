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
    class SearchLayout
    {
        private Context context;
        private int arrayId;
        private string[] fields;
        private TextView[] txtTitle;
        private EditText[] edField;
        private ArrayAdapter adapter;
        public Spinner spnType;
        public Button btnSearch;

        public SearchLayout(int arrayId, string[] fields, Context context)
        {
            this.arrayId = arrayId;
            this.fields = fields;
            this.context = context;

            txtTitle = new TextView[fields.Length];
            edField = new EditText[fields.Length];
            spnType = new Spinner(context);
            btnSearch = new Button(context);

            adapter = ArrayAdapter.CreateFromResource(context, arrayId, Android.Resource.Layout.SimpleSpinnerItem);
            adapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            spnType.Adapter = adapter;
        }

        public void CreateLayout()
        {
            for (int i = 0; i < fields.Length; i++)
            {
                txtTitle[i] = new TextView(context);
                txtTitle[i].Text = fields[i];
                edField[i] = new EditText(context);
                edField[i].InputType = Android.Text.InputTypes.TextVariationNormal;
            }
        }
    }
}