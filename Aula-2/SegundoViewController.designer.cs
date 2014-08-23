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

namespace Aula2
{
	[Register ("SegundoViewController")]
	partial class SegundoViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btnEditar { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lblSegundaTela { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITableView tvTabela { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (btnEditar != null) {
				btnEditar.Dispose ();
				btnEditar = null;
			}
			if (lblSegundaTela != null) {
				lblSegundaTela.Dispose ();
				lblSegundaTela = null;
			}
			if (tvTabela != null) {
				tvTabela.Dispose ();
				tvTabela = null;
			}
		}
	}
}
