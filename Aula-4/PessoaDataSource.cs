using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;
using SQLite.Net;
using System.IO;
using SQLite.Net.Platform.XamarinIOS;

namespace Aula4
{
	public class PessoaDataSource : UITableViewDataSource
	{
		SQLiteConnection db;

		#region implemented abstract members of UITableViewDataSource

		public PessoaDataSource() {
			var dbFile = Path.Combine (Environment.GetFolderPath(Environment.SpecialFolder.Personal), "my-data.db");

			db = new SQLiteConnection (new SQLitePlatformIOS (), dbFile);
			db.CreateTable<Pessoa> ();
		}

		public override int RowsInSection (UITableView tableView, int section)
		{

			return db.Table<Pessoa> ().Count();
		}

		public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
		{
			var cell = tableView.DequeueReusableCell ("pessoa");

			if (cell == null)
				cell = new UITableViewCell (UITableViewCellStyle.Value1, "pessoa");

			var pessoa = db.Table<Pessoa> ().Where(p => p.Id == indexPath.Row + 1).FirstOrDefault();

			cell.TextLabel.Text = pessoa.Nome;
			cell.DetailTextLabel.Text = pessoa.Telefone;

			return cell;
		}

		#endregion
	}

}
