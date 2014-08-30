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
	[Register ("PreferenciasViewController")]
	partial class PreferenciasViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UISwitch boolSwitch { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btnGravar { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btnLer { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIDatePicker dtPicker { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UISlider floatSlider { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIStepper intStepper { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lblInt { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField txtNome { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (boolSwitch != null) {
				boolSwitch.Dispose ();
				boolSwitch = null;
			}
			if (btnGravar != null) {
				btnGravar.Dispose ();
				btnGravar = null;
			}
			if (btnLer != null) {
				btnLer.Dispose ();
				btnLer = null;
			}
			if (dtPicker != null) {
				dtPicker.Dispose ();
				dtPicker = null;
			}
			if (floatSlider != null) {
				floatSlider.Dispose ();
				floatSlider = null;
			}
			if (intStepper != null) {
				intStepper.Dispose ();
				intStepper = null;
			}
			if (lblInt != null) {
				lblInt.Dispose ();
				lblInt = null;
			}
			if (txtNome != null) {
				txtNome.Dispose ();
				txtNome = null;
			}
		}
	}
}
