// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;

namespace FirstXamariniOSDemo
{
	[Register ("FirstXamariniOSDemoViewController")]
	partial class FirstXamariniOSDemoViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btnClick { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel labDisplay { get; set; }

		[Action ("btnClick_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void btnClick_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (btnClick != null) {
				btnClick.Dispose ();
				btnClick = null;
			}
			if (labDisplay != null) {
				labDisplay.Dispose ();
				labDisplay = null;
			}
		}
	}
}
