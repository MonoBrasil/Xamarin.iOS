using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;

namespace Aula4
{
	partial class PreferenciasViewController : UIViewController
	{
		private NSUserDefaults prefs = NSUserDefaults.StandardUserDefaults;
		public PreferenciasViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			LePreferencias ();

			txtNome.ShouldReturn += (textField) => {
				txtNome.ResignFirstResponder();
				return true;
			};

			btnLer.TouchUpInside += (object sender, EventArgs e) => {
				LePreferencias();
			};

			btnGravar.TouchUpInside += (object sender, EventArgs e) => {
				prefs.SetBool (boolSwitch.On, "habilitado");
				prefs.SetString (txtNome.Text, "user");
				prefs.SetFloat (floatSlider.Value, "slider");
				prefs.SetInt (Convert.ToInt32(lblInt.Text), "int");
				prefs.SetDouble (dtPicker.Date.SecondsSinceReferenceDate , "data");
			};

			intStepper.ValueChanged	+= (object sender, EventArgs e) => {
				lblInt.Text = intStepper.Value.ToString();
			};
		}

		void LePreferencias ()
		{
			txtNome.Text = prefs.StringForKey ("user");
			boolSwitch.SetState (prefs.BoolForKey ("habilitado"), true);
			floatSlider.Value = prefs.FloatForKey ("slider");
			lblInt.Text = prefs.IntForKey ("int").ToString();
			intStepper.Value = prefs.IntForKey ("int");
			dtPicker.Date = NSDate.FromTimeIntervalSince1970 (prefs.DoubleForKey ("data"));
		}
	}
}
