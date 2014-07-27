using System;
using MonoTouch.UIKit;

namespace ThirdXamariniOSDemo
{
	public class FirstWayViewController: UIViewController
	{
		public FirstWayViewController () : base ()
		{
		}

		UIButton btnClose;
		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();

			// Release any cached data, images, etc that aren't in use.
		}

		#region View lifecycle

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			// Perform any additional setup after loading the view, typically from a nib.
			View.BackgroundColor = UIColor.Red;
			btnClose = UIButton.FromType(UIButtonType.RoundedRect);
			btnClose.Frame = new System.Drawing.RectangleF(110,160,100,30);
			btnClose.SetTitle(@"Close",UIControlState.Normal);
			btnClose.TouchUpInside += onBtnClose;

			View.AddSubview(btnClose);
		}

		void onBtnClose (object sender, EventArgs e)
		{
			DismissViewController(true,null);
		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
		}

		public override void ViewDidAppear (bool animated)
		{
			base.ViewDidAppear (animated);
		}

		public override void ViewWillDisappear (bool animated)
		{
			base.ViewWillDisappear (animated);
		}

		public override void ViewDidDisappear (bool animated)
		{
			base.ViewDidDisappear (animated);
		}

		#endregion
	}
}

