using System;
using System.Drawing;
using System.IO;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.Text;

namespace Aula4
{
	public partial class Aula_4ViewController : UIViewController
	{
		private string arquivo = Path.Combine (
			Environment.GetFolderPath (Environment.SpecialFolder.MyDocuments),
			"meu-texto.txt");

		public Aula_4ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		#region View lifecycle

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			btnGravar.TouchUpInside += (object sender, EventArgs e) => {
				if (!File.Exists(arquivo)) {
					// Criar o arquivo
				}

				using (var writer = File.AppendText (arquivo)) {

					writer.WriteLine (txtField.Text);
					writer.Flush ();
				}

				txtField.ResignFirstResponder();
			};

			txtField.ShouldReturn += (textField) => {
				txtField.ResignFirstResponder ();

				return true;
			};

			btnLer.TouchUpInside += (object sender, EventArgs e) => {
				var sb = new StringBuilder();
				var index = 0;
				using (var reader = File.OpenText (arquivo)) {

					while (!reader.EndOfStream) {
						index++;
						sb.AppendFormat("Linha {0}: {1}\n", index, reader.ReadLine ());
					}
				}

				txtLido.Text = sb.ToString();
			};

		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
		}

		public override void ViewDidAppear (bool animated)
		{
			base.ViewDidAppear (animated);
		}

		public override void ViewWillDisappear (bool animated)
		{
			base.ViewWillDisappear (animated);
		}

		public override void ViewDidDisappear (bool animated)
		{
			base.ViewDidDisappear (animated);
		}

		#endregion
	}
}

