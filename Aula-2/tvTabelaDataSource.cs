using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;

namespace Aula2
{
	public class tvTabelaDataSource : UITableViewDataSource
	{
		private string[] lista = { "maçã", "banana", "pêra", "limão", 
			"laranja", "uva", "kiwi", "morango", "tomate", "melancia",
			"caju", "melão", "cajá", "pequi", "ameixa",
			"laranja 2", "uva 2", "kiwi 2", "morango 2", "tomate 2", "melancia 2",
			"caju 2", "melão 2", "cajá 2", "pequi 2", "ameixa 2"};

		#region implemented abstract members of UITableViewDataSource

		public override int RowsInSection (UITableView tableView, int section)
		{
			return lista.Length;
		}

		public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
		{
			UITableViewCell celula;

			celula = tableView.DequeueReusableCell ("minha-celula");

			if (celula == null) {
				celula = new UITableViewCell (UITableViewCellStyle.Default, "minha-celula");
			}

			celula.TextLabel.Text = lista[indexPath.Row];

			return celula;
		}

		public string GetItem(NSIndexPath indexPath) {
			return lista [indexPath.Row];
		}

		#endregion


	}

}
