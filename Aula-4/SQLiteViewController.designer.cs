// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;

namespace Aula4
{
	[Register ("SQLiteViewController")]
	partial class SQLiteViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btnInserir { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITableView tvTabela { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField txtNome { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField txtTefone { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (btnInserir != null) {
				btnInserir.Dispose ();
				btnInserir = null;
			}
			if (tvTabela != null) {
				tvTabela.Dispose ();
				tvTabela = null;
			}
			if (txtNome != null) {
				txtNome.Dispose ();
				txtNome = null;
			}
			if (txtTefone != null) {
				txtTefone.Dispose ();
				txtTefone = null;
			}
		}
	}
}
