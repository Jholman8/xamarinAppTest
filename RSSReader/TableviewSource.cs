using System;
using UIKit;

namespace RSSReader
{
	public class TableviewSource : UITableViewSource
	{
		string[] tableItems;
		string cellIdentifier = "TableCell";

		public TableviewSource (string[] items)
		{
			tableItems = items;
		}
		public override nint RowsInSection (UITableView tableview, nint section)
		{
			return tableItems.Length;
		}

		public override UITableViewCell GetCell (UITableView tableView, Foundation.NSIndexPath indexPath)
		{
			UITableViewCell cell = tableView.DequeueReusableCell (cellIdentifier);
			if (cell == null) {
				cell = new UITableViewCell (UITableViewCellStyle.Default, cellIdentifier); 
			}
			cell.TextLabel.Text = tableItems[indexPath.Row];
			return cell;
		}
		public override void RowSelected (UITableView tableview, Foundation.NSIndexPath indexPath){
			new UIAlertView ("Alert","You touched: " + tableItems[indexPath.Row],null, "OK",null).Show();

		}
	}
}

