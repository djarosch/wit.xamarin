using System;
using BigTed;
using UIKit;

namespace hello.iOS
{
	public partial class ViewController : UIViewController
	{
		int count = 1;

		public ViewController (IntPtr handle) : base (handle)
		{		
		}


		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			// Code to start the Xamarin Test Cloud Agent
			#if ENABLE_TEST_CLOUD
			Xamarin.Calabash.Start ();
			#endif

		    CheckButton.TouchUpInside += OnButtonOnTouchUpInside;
		}

	    private async void OnButtonOnTouchUpInside(object sender, EventArgs e)
	    {
            var phone = phoneTxtField.Text;
            var gsmService = new GsMService();
            var result = await gsmService.Check(phone);
            if (result.Success)
            {
                BTProgressHUD.ShowSuccessWithStatus(string.Format("{0}: {1}", phone, result.Data)); 
            }
            else
            {
                BTProgressHUD.ShowErrorWithStatus(string.Format("{0}: unknown", phone)); 
            }
	    }

	    public override void DidReceiveMemoryWarning ()
		{		
			base.DidReceiveMemoryWarning ();		
			// Release any cached data, images, etc that aren't in use.		
		}

     
	}
}
