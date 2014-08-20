using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;

namespace Aula2
{
	partial class SegundoViewController : UIViewController
	{
		public SegundoViewController (IntPtr handle) : base (handle)
		{
		}

		public SegundoViewController () : base () 
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			tvTabela.Delegate = new tvTabelaDelegate ();
			tvTabela.DataSource = new tvTabelaDataSource ();
			(tvTabela.Delegate as tvTabelaDelegate).OnSelected = (item) => {
				lblSegundaTela.Text = string.Format("Selecionado: {0}", item);
			};

		}
	}
}
