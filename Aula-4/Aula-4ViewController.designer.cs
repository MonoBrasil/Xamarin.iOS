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
	[Register ("Aula_4ViewController")]
	partial class Aula_4ViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		MonoTouch.UIKit.UIButton btnGravar { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		MonoTouch.UIKit.UIButton btnLer { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		MonoTouch.UIKit.UITextField txtField { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		MonoTouch.UIKit.UITextView txtLido { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (btnGravar != null) {
				btnGravar.Dispose ();
				btnGravar = null;
			}
			if (btnLer != null) {
				btnLer.Dispose ();
				btnLer = null;
			}
			if (txtField != null) {
				txtField.Dispose ();
				txtField = null;
			}
			if (txtLido != null) {
				txtLido.Dispose ();
				txtLido = null;
			}
		}
	}
}
