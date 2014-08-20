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
	[Register ("Aula_2ViewController")]
	partial class Aula_2ViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		MonoTouch.UIKit.UIButton btnAcao { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		MonoTouch.UIKit.UIButton btnProximaTela { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		MonoTouch.UIKit.UIButton btnTerceiraTela { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		MonoTouch.UIKit.UILabel lblMensagem { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		MonoTouch.UIKit.UITextField txtTeste { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (btnAcao != null) {
				btnAcao.Dispose ();
				btnAcao = null;
			}
			if (btnProximaTela != null) {
				btnProximaTela.Dispose ();
				btnProximaTela = null;
			}
			if (btnTerceiraTela != null) {
				btnTerceiraTela.Dispose ();
				btnTerceiraTela = null;
			}
			if (lblMensagem != null) {
				lblMensagem.Dispose ();
				lblMensagem = null;
			}
			if (txtTeste != null) {
				txtTeste.Dispose ();
				txtTeste = null;
			}
		}
	}
}
