using System;
using System.Net;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Uri = Android.Net.Uri;
using Android.Database;

namespace SendSimpleFileAndroid
{
    [Activity(Label = "SendSimpleFileAndroid", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        Button btnBrowse;
        Button btnSend;
        ImageView imgView;
        int imgID = 1000;
        WebClient client;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            client = new WebClient();
            btnBrowse = FindViewById<Button>(Resource.Id.btnBrowse);
            btnSend = FindViewById<Button>(Resource.Id.btnSend);
            imgView = FindViewById<ImageView>(Resource.Id.imgView);

            btnBrowse.Click += (sender, e) =>
            {
                Intent = new Intent();
                Intent.SetType("image/*");
                Intent.SetAction(Intent.ActionGetContent);
                StartActivityForResult(Intent.CreateChooser(Intent, "Browse Image"), imgID);
            };

            btnSend.Click += (sender, e) =>
            {

            };

            /*button.Click += delegate
            {
                
                try
                {
                    //client.UploadFile("ftp://Test@10.250.77.37/Test2/camera-icon-png-4i9a9x64T.png", "Resources/drawable/camera-icon-png-4i9a9x64T.png");
                    Toast.MakeText(this, "Send succesfully", ToastLength.Long);
                    button.Text = string.Format("{0} clicks!", count++);
                }
                catch (Exception e)
                {
                    Toast.MakeText(this,e.Message, ToastLength.Long);
                }
            };*/
        }

        protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);
            if ((requestCode == imgID) && (resultCode == Result.Ok) && (data != null))
            {
                Uri uri = data.Data;
                imgView.SetImageURI(uri);

                string path = GetPathToImage(uri);
                Toast.MakeText(this, path, ToastLength.Long).Show();
            }
        }

        private string GetPathToImage(Uri uri)
        {
            string path = null;
            // The projection contains the columns we want to return in our query.
            string[] projection = new[] { Android.Provider.MediaStore.Images.Media.InterfaceConsts.Data };
            using (ICursor cursor = ManagedQuery(uri, projection, null, null, null))
            {
                if (cursor != null)
                {
                    int columnIndex = cursor.GetColumnIndexOrThrow(Android.Provider.MediaStore.Images.Media.InterfaceConsts.Data);
                    cursor.MoveToFirst();
                    path = cursor.GetString(columnIndex);
                }
            }
            return path;
        }
    }
}

