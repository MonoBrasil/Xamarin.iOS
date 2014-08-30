using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;
using SQLite.Net;
using System.IO;
using SQLite.Net.Platform.XamarinIOS;

namespace Aula4
{
	partial class SQLiteViewController : UIViewController
	{
		SQLiteConnection db;

		public SQLiteViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			var dbFile = Path.Combine (Environment.GetFolderPath(Environment.SpecialFolder.Personal), "my-data.db");

			db = new SQLiteConnection (new SQLitePlatformIOS (), dbFile);
			db.CreateTable<Pessoa>();

			btnInserir.TouchUpInside += (object sender, EventArgs e) => {
				var pessoa = new Pessoa() {
					Nome = txtNome.Text,
					Telefone = txtTefone.Text
				};

				db.Insert(pessoa);
				tvTabela.ReloadData();
			};

			tvTabela.DataSource = new PessoaDataSource ();
		}
	}
}
