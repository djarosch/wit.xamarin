using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace hello.Droid
{
	[Activity (Label = "Check phone operator", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{

	    private EditText _phoneEdit;

	    protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.myButton);			
			button.Click += OnButtonOnClick;

            _phoneEdit = FindViewById<EditText>(Resource.Id.phoneText);	
		}

	    private async void OnButtonOnClick(object sender, EventArgs e)
	    {
            var phone = _phoneEdit.Text;
	        var gsmService = new GsMService();
	        var result = await gsmService.CheckAsync(phone);
	        if (result.Success)
	        {
	            Toast.MakeText(this, string.Format("{0}: {1}",phone,result.Data),ToastLength.Long).Show();
	        }
	        else
	        {
                Toast.MakeText(this, string.Format("{0}: unknown", phone), ToastLength.Long).Show();	            
	        }
	    }
	}
}


