using System;
using CoreGraphics;
using System.Linq;
using UIKit;
using Foundation;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Net;
using System.Threading;
using System.IO;
namespace RSSReader
{
	public partial class AppViewController : UITableViewController
	{
		public ObservableCollection<App> Apps { get; private set; }

		public AppViewController (string nibName, NSBundle bundle) : base (nibName, bundle)
		{
			Apps = new ObservableCollection<App> ();
			Title = NSBundle.MainBundle.LocalizedString ("Top 25 Free Apps", "Master");
		}
		public AppViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.
//			string[] data = new string[]{"test","test2"};
			TableView.Source = new DataSource (this);
		}



		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}


