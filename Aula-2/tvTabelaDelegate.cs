using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;

namespace Aula2
{
	public delegate void Selecionado(string item);
	public delegate string Inserido();

	public class tvTabelaDelegate : UITableViewDelegate
	{
		public tvTabelaDelegate() : base () {
		}

		public Selecionado OnSelected;
		public Inserido OnInsert;

		public override void RowSelected (UITableView tableView, NSIndexPath indexPath)
		{
			if (indexPath.Row == tableView.NumberOfRowsInSection (0) - 1) {
				if (OnInsert != null) {
					var item = OnInsert ();
					(tableView.DataSource as tvTabelaDataSource).Insert (item);
					tableView.InsertRows (new NSIndexPath[]{ NSIndexPath.FromItemSection (tableView.NumberOfRowsInSection(0) - 1, 0)
					}, UITableViewRowAnimation.Bottom);
				}
			} else {
				if (OnSelected != null) {
					string item = (tableView.DataSource as tvTabelaDataSource).GetItem (indexPath);
					OnSelected (item);
				}
			}
		}

		public override float GetHeightForRow (UITableView tableView, NSIndexPath indexPath)
		{
			return 40;
		}

		public override UIView GetViewForHeader (UITableView tableView, int section)
		{
			var cabecalho = new UILabel ();
			cabecalho.Text = "Cabeçalho";
			return cabecalho;
		}

		public override UIView GetViewForFooter (UITableView tableView, int section)
		{
			var rodape = new UILabel ();
			rodape.Text = "Rodapé";
			return rodape;
		}

		public override UITableViewCellEditingStyle EditingStyleForRow (UITableView tableView, NSIndexPath indexPath)
		{
			if (tableView.Editing) {
				if (indexPath.Row == tableView.NumberOfRowsInSection (0) - 1)
					return UITableViewCellEditingStyle.Insert;
				else
					return UITableViewCellEditingStyle.Delete;
			} else {
				return UITableViewCellEditingStyle.Delete;
			}
		}
			
		public void WillBeginEditing (UITableView tableView)
		{
			tableView.BeginUpdates ();

			tableView.InsertRows (new NSIndexPath[] { NSIndexPath.FromRowSection(tableView.NumberOfRowsInSection (0), 0) },
				UITableViewRowAnimation.Fade);

			(tableView.DataSource as tvTabelaDataSource).InsertAddItem ();

			tableView.EndUpdates ();
		}

		public void DidEndEditing (UITableView tableView)
		{
			tableView.BeginUpdates ();

			tableView.DeleteRows (new NSIndexPath[] { NSIndexPath.FromRowSection(tableView.NumberOfRowsInSection(0) - 1, 0) }, 
				UITableViewRowAnimation.Left);

			(tableView.DataSource as tvTabelaDataSource).RemoveAddItem ();

			tableView.EndUpdates ();
		}



	}

}
