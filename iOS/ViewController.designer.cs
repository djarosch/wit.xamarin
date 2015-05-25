// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace hello.iOS
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		UIKit.UIButton Button { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton CheckButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField phoneTxtField { get; set; }

		[Action ("Button_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void Button_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (CheckButton != null) {
				CheckButton.Dispose ();
				CheckButton = null;
			}
			if (phoneTxtField != null) {
				phoneTxtField.Dispose ();
				phoneTxtField = null;
			}
		}
	}
}
