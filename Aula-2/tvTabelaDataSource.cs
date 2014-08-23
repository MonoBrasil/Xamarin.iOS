using System;
using System.Collections.Generic;
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

		public void Insert (string item)
		{
			List<string> temp = new List<string> (lista);
			temp.Insert(temp.Count - 1, item);
			lista = temp.ToArray();
		}

		public void InsertAddItem ()
		{
			List<string> temp = new List<string> (lista);
			temp.Add ("** Adicionar Item **");
			lista = temp.ToArray();
		}

		public void RemoveAddItem ()
		{
			List<string> temp = new List<string> (lista);
			temp.RemoveAt (temp.Count - 1);
			lista = temp.ToArray();
		}

		public override bool CanEditRow (UITableView tableView, NSIndexPath indexPath)
		{
			return true;
		}

		public override bool CanMoveRow (UITableView tableView, NSIndexPath indexPath)
		{
			return (indexPath.Row != tableView.NumberOfRowsInSection (0) - 1);
		}

		public override void MoveRow (UITableView tableView, NSIndexPath sourceIndexPath, NSIndexPath destinationIndexPath)
		{
			List<string> temp = new List<string> (lista);
			int origem = sourceIndexPath.Row;
			int destino = destinationIndexPath.Row;

			var elemento = temp [origem];

			if (origem < destino) {
				destino--;
			} 

			temp.RemoveAt (origem);
			temp.Insert (destino, elemento);

			lista = temp.ToArray();
		}

		public override void CommitEditingStyle (UITableView tableView, UITableViewCellEditingStyle editingStyle, NSIndexPath indexPath)
		{
			switch (editingStyle) {
			case UITableViewCellEditingStyle.Delete:
				List<string> temp = new List<string> (lista);
				temp.RemoveAt (indexPath.Row);
				lista = temp.ToArray ();
				tableView.DeleteRows (new NSIndexPath[] { indexPath }, UITableViewRowAnimation.Right);
				break;
			case UITableViewCellEditingStyle.Insert:
				break;
			default:
				break;
			}
		}

	}

}
