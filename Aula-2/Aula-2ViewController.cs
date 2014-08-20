using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace Aula2
{
	public partial class Aula_2ViewController : UIViewController
	{
		public Aula_2ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		private int numeroCliques = 0;

		#region View lifecycle

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			btnAcao.TouchUpInside += (sender, e) => {
				numeroCliques++;
				var mensagem = string.IsNullOrEmpty(txtTeste.Text) ? "Foram clicadas {0} vezes" : txtTeste.Text;
				lblMensagem.Text = string.Format(mensagem, numeroCliques);
			};

			txtTeste.ShouldReturn = (textField) => {
				txtTeste.ResignFirstResponder();
				var mensagem = string.IsNullOrEmpty(txtTeste.Text) ? "Foram clicadas {0} vezes" : txtTeste.Text;
				lblMensagem.Text = string.Format(mensagem, numeroCliques);
				return true;
			};

			//btnProximaTela.TouchUpInside += (sender, e) => {
				//var tela2 = new SegundoViewController();
				//var tela2 = (SegundoViewController) Storyboard.InstantiateViewController("segunda-tela");
				//PresentViewController(tela2, true, null);
			//};
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

