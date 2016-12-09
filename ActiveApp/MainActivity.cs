using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;
using Android.Net;
using Java.Lang;
using Android.Util;

namespace ActiveApp
{
    [Activity(Label = "ActiveApp", MainLauncher = true, Icon = "@drawable/icon")]
    [IntentFilter(new[] { Android.Content.Intent.ActionView },
            AutoVerify = true,
            Categories = new[] {
                Android.Content.Intent.CategoryLauncher,
                Android.Content.Intent.CategoryDefault,
                Android.Content.Intent.CategoryBrowsable
            },
            DataScheme = "https",
            DataHost = "myexample.com",
            DataPathPattern = ""
        )]
    public class MainActivity : Activity

    {
        TextView tv1;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource

            SetContentView(Resource.Layout.Main);

            try
            {
                Uri myURI = Intent.Data;
                Uri address1 = Uri.Parse("https://myexample.com/");
                Log.Error("Mike", myURI + "" + address1);
                tv1 = (TextView)FindViewById(Resource.Id.textView1);
                tv1.Text = address1 + "   " + myURI;
                if (myURI == null)
                {
                    SetContentView(Resource.Layout.Main);
                }
                else if (myURI.Equals(address1))
                {
                    StartActivity(typeof(Activity1));
                }
                else
                {
                    //StartActivity(typeof(YourActivity1));
                }
            }
            catch (Exception e)
            {

            }
            finally {
               
            }

          

        }
    }
}

