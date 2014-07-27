using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace ThirdXamariniOSDemo
{
	public partial class ThirdXamariniOSDemoViewController : UIViewController
	{
		public ThirdXamariniOSDemoViewController (IntPtr handle) : base (handle)
		{
		}

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


		partial void FirstWay_TouchUpInside (UIButton sender)
		{
			this.PresentViewController(new FirstWayViewController(),true,null);
		
		}

		partial void SecondWay_TouchUpInside (UIButton sender)
		{
			throw new NotImplementedException ();
		}

		partial void ThirdWay_TouchUpInside (UIButton sender)
		{
			throw new NotImplementedException ();
		}
		#endregion
	}
}

