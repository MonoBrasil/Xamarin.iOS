using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;
using System.Reflection;

namespace Aula2
{
	partial class TerceiraTelaViewController : UITableViewController
	{
		public TerceiraTelaViewController (IntPtr handle) : base (handle)
		{
		}

		private string[] lista = { "marte", "venus", "terra", "saturno", "netuno",
			"urano", "mercurio", "plutão",
			"marte 2", "venus 2", "terra 2", "saturno 2", "netuno 2",
			"urano 2", "mercurio 2", "plutão 2",
			"marte 3", "venus 3", "terra 3", "saturno 3", "netuno 3",
			"urano 3", "mercurio 3", "plutão 3"};

		public override int RowsInSection (UITableView tableView, int section)
		{
			return lista.Length;
		}

		public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
		{
			AulaCell celula;

			celula = tableView.DequeueReusableCell ("celula-aula") as AulaCell;

			if (celula == null) {
				celula = new AulaCell ("celula-aula");
			}

			var img = UIImage.FromFile("planeta.jpg");
			celula.UpdateCell(lista[indexPath.Row], string.Format ("Linha {0}", indexPath.Row),
				img);

			return celula;
		}

		public override float GetHeightForRow (UITableView tableView, NSIndexPath indexPath)
		{
			return 60;
		}

		public override UIView GetViewForHeader (UITableView tableView, int section)
		{
			var cabecalho = new UILabel ();
			cabecalho.Text = "Meus planetas";
			return cabecalho;
		}

		public override UIView GetViewForFooter (UITableView tableView, int section)
		{
			var rodape = new UILabel ();
			rodape.Text = "Sistema Solar";
			return rodape;
		}

		public override void RowSelected (UITableView tableView, NSIndexPath indexPath)
		{
			var alerta = new UIAlertView ("Planeta", lista [indexPath.Row], null, "OK");
			alerta.Show ();
		}
	}
}
