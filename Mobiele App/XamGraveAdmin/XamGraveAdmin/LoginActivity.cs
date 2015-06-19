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
    [Activity(Label = "Grave Admin", MainLauncher = true, Icon = "@drawable/icon")]
    public class LoginActivity : Activity
    {
        EditText edUser;
        EditText edPass;
        Button btnLogin;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            // Create your application here
            SetContentView(Resource.Layout.login);
            edUser = FindViewById<EditText>(Resource.Id.edUser);
            edPass = FindViewById<EditText>(Resource.Id.edPass);
            btnLogin = FindViewById<Button>(Resource.Id.btnLogin);

            btnLogin.Click += (sender, e) => 
            {
                if (edUser.Text == "admin" && edPass.Text == "admin")
                {
                    StartActivity(typeof(MainActivity));
                    CreateToast("Welcome");
                }
                else
                {
                    CreateToast("Username and/or password are incorrect");
                }
                edUser.Text = "";
                edPass.Text = "";
            };
        }

        private void CreateToast(string text)
        {
            Toast.MakeText(this, text, ToastLength.Short).Show();
        }
    }
}