package com.example.graveadmin;

import android.app.Activity;
import android.content.Context;
import android.os.Bundle;
import android.view.Gravity;
//import android.view.Menu;
//import android.view.MenuItem;
import android.view.View;
import android.view.Window;
import android.support.v4.widget.*;
import android.widget.*;
import android.widget.AdapterView.OnItemClickListener;
import android.widget.AdapterView.OnItemSelectedListener;

public class MainActivity extends Activity {
	protected static final Context MainActivity = null;
	private ListView lvNav;
	private DrawerLayout lyDraw;
	private ImageButton btnDraw;
	private LinearLayout lySearch;
	private Spinner spnWay;
	
	private ArrayAdapter<CharSequence> adNav;
	private ArrayAdapter<CharSequence> adWay;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
    	requestWindowFeature(Window.FEATURE_NO_TITLE);
        super.onCreate(savedInstanceState);
        setContentView(R.layout.layout_main);
        
        lvNav = (ListView)findViewById(R.id.lvNav);
        lyDraw = (DrawerLayout)findViewById(R.id.lyDraw);
        btnDraw = (ImageButton)findViewById(R.id.btnDraw);
        lySearch = (LinearLayout)findViewById(R.id.lySearch);
        spnWay = (Spinner)findViewById(R.id.spnWay);
        
        adNav = ArrayAdapter.createFromResource(this, R.array.drawerArray, android.R.layout.simple_list_item_1);
        lvNav.setAdapter(adNav);
        
        final Toast myToast = Toast.makeText(this, "Selected item", Toast.LENGTH_SHORT);
        
        //click events
        lvNav.setOnItemClickListener(new OnItemClickListener(){

			@Override
			public void onItemClick(AdapterView<?> parent, View view,
					int position, long id) {
				// TODO Auto-generated method stub
				SetSpinner(position, adWay, spnWay);
				lyDraw.closeDrawer(Gravity.START);
				
			}
        });
        
        btnDraw.setOnClickListener(new View.OnClickListener() {
			
			@Override
			public void onClick(View v) {
				// TODO Auto-generated method stub
				lyDraw.openDrawer(Gravity.START);
				Toast.makeText(getBaseContext(), String.format("Selected item {0}", lvNav.getSelectedItem()), Toast.LENGTH_SHORT);
			}
		});
        
        SetSpinner(0, adWay, spnWay);
        spnWay.setOnItemSelectedListener(new OnItemSelectedListener(){

			@Override
			public void onItemSelected(AdapterView<?> parent, View view,
					int position, long id) {
				// TODO Auto-generated method stub
				GenerateSearchLayout(spnWay.getItemAtPosition(position).toString());
			}

			@Override
			public void onNothingSelected(AdapterView<?> parent) {
				// TODO Auto-generated method stub
				
			}
        	
        });
    }
    
    //Custom Methods
    private void SetSpinner(int pos, ArrayAdapter<CharSequence> arrayList, Spinner spin)
    {
        int array = 0;
        switch (pos)
        {
            case 0:
                array = R.array.subjectArray;
                break;
            case 1:
                array = R.array.graveArray;
                break;
            case 2:
                array = R.array.deceasedArray;
                break;
        }

        arrayList = ArrayAdapter.createFromResource(this, array, android.R.layout.simple_spinner_item);
        arrayList.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);
        spin.setAdapter(arrayList);
    }
    private void GenerateSearchLayout(String item)
    {
        lySearch.removeAllViews();
        //subject
        if (item.contains("post"))
        {
            CreateInputField(lySearch, "Postcode", android.text.InputType.TYPE_TEXT_VARIATION_POSTAL_ADDRESS);
            CreateInputField(lySearch, "Huisnummer", android.text.InputType.TYPE_NUMBER_VARIATION_NORMAL);
        }
        else if (item.contains("straat"))
        {
            CreateInputField(lySearch, "Straat", android.text.InputType.TYPE_TEXT_VARIATION_SHORT_MESSAGE);
            CreateInputField(lySearch, "Huisnummer", android.text.InputType.TYPE_NUMBER_VARIATION_NORMAL);
        }
        else if (item.contains("geboortedatum"))
        {
            CreateInputField(lySearch, "Geboortedatum", android.text.InputType.TYPE_DATETIME_VARIATION_DATE);
            CreateInputField(lySearch, "Naam", android.text.InputType.TYPE_TEXT_VARIATION_PERSON_NAME);
        }
        else if (item.contains("overledene"))
        {
            CreateSpinnerField(lySearch, "Begraafplaats", new String[] { "Generale Begraafplaats" });
            CreateInputField(lySearch, "overlijdensdatum", android.text.InputType.TYPE_DATETIME_VARIATION_DATE);
            CreateInputField(lySearch, "naam", android.text.InputType.TYPE_TEXT_VARIATION_PERSON_NAME);
        }
        else if (item.contains("subject naam"))
        {
            CreateInputField(lySearch, "Naam", android.text.InputType.TYPE_TEXT_VARIATION_PERSON_NAME);
            CreateInputField(lySearch, "Straat", android.text.InputType.TYPE_TEXT_VARIATION_SHORT_MESSAGE);
        }
        else if (item.contains("bsn"))
        {
            CreateInputField(lySearch, "BSN/Sofi-Nummer", android.text.InputType.TYPE_NUMBER_VARIATION_NORMAL);
        }
        else if (item.contains("a-"))
        {
            CreateInputField(lySearch, "A-Nummer", android.text.InputType.TYPE_NUMBER_VARIATION_NORMAL);
        }
        else if (item.contains("subjectcode"))
        {
            CreateInputField(lySearch, "Subject-code", android.text.InputType.TYPE_TEXT_VARIATION_SHORT_MESSAGE);
        }
        else if(item.contains("advanced"))
        {
        	CreateInputField(lySearch, "Geboorte Datum", android.text.InputType.TYPE_DATETIME_VARIATION_DATE);
        	CreateInputField(lySearch, "Subject nummer", android.text.InputType.TYPE_TEXT_VARIATION_SHORT_MESSAGE);
        	CreateInputField(lySearch, "BSN/Sofi-Nummer", android.text.InputType.TYPE_NUMBER_VARIATION_NORMAL);
        	CreateInputField(lySearch, "Postcode", android.text.InputType.TYPE_TEXT_VARIATION_POSTAL_ADDRESS);
        	CreateInputField(lySearch, "Straat", android.text.InputType.TYPE_TEXT_VARIATION_SHORT_MESSAGE);
        	CreateSpinnerField(lySearch, "Soorten", R.array.typeArray);
        }
        //grave
        else if (item.contains("begraafplaats"))
        {
        	CreateSpinnerField(lySearch, "Begraafplaats", new String[] { "Generale Begraafplaats" });
        	CreateInputField(lySearch, "Graf ID", android.text.InputType.TYPE_TEXT_VARIATION_SHORT_MESSAGE);
        }
        else if (item.contains("locatie"))
        {
        	CreateInputField(lySearch, "Locatie", android.text.InputType.TYPE_TEXT_VARIATION_SHORT_MESSAGE);
        }
        else if (item.contains("hebbende"))
        {
        	CreateSpinnerField(lySearch, "Begraafplaats", new String[] { "Generale Begraafplaats" });
        	CreateInputField(lySearch, "Naam", android.text.InputType.TYPE_TEXT_VARIATION_PERSON_NAME);
        	CreateInputField(lySearch, "Geboorte Datum", android.text.InputType.TYPE_DATETIME_VARIATION_DATE);        	
        }
        //deceased
        else if (item.contains("overledene naam"))
        {
            CreateSpinnerField(lySearch, "Begraafplaats", new String[] { "Generale Begraafplaats" });
            CreateInputField(lySearch, "Naam", android.text.InputType.TYPE_TEXT_VARIATION_PERSON_NAME);
            CreateInputField(lySearch, "Geboortedatum", android.text.InputType.TYPE_DATETIME_VARIATION_DATE);
            CreateInputField(lySearch, "Overlijdensdatum", android.text.InputType.TYPE_DATETIME_VARIATION_DATE);
            
        }
        
        Button btnSearch = new Button(this);
        btnSearch.setText("Zoeken");
        lySearch.addView(btnSearch);

    }

    private void CreateInputField(LinearLayout layout, String label, int inputType)
    {
        TextView tView = new TextView(this);
        tView.setText(label);
        EditText eTxt = new EditText(this);

        eTxt.setInputType(inputType);
        eTxt.setMaxLines(1);

        layout.addView(tView);
        layout.addView(eTxt);
    }

    private void CreateSpinnerField(LinearLayout layout, String label, String[] values)
	{
		TextView tView = new TextView (this);
		tView.setText(label);

		ArrayAdapter<String> adapter = new ArrayAdapter<String>(this, android.R.layout.simple_spinner_item);
        adapter.addAll(values);
		Spinner spnView = new Spinner (this);
		spnView.setAdapter(adapter);

		layout.addView (tView);
		layout.addView (spnView);
	}
    private void CreateSpinnerField(LinearLayout layout, String label, int array)
	{
		TextView tView = new TextView (this);
		tView.setText(label);

		ArrayAdapter<CharSequence> arrayList = ArrayAdapter.createFromResource(this, array, android.R.layout.simple_spinner_item);
        arrayList.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);
		Spinner spnView = new Spinner (this);
		spnView.setAdapter(arrayList);

		layout.addView (tView);
		layout.addView (spnView);
	}
}
