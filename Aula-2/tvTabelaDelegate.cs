using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;

namespace Aula2
{
	public delegate void Selecionado(string item);

	public class tvTabelaDelegate : UITableViewDelegate
	{
		public tvTabelaDelegate() : base () {
		}

		public Selecionado OnSelected;

		public override void RowSelected (UITableView tableView, NSIndexPath indexPath)
		{
			if (OnSelected != null) {
				string item = (tableView.DataSource as tvTabelaDataSource).GetItem (indexPath);
				OnSelected (item);
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
	}

}
