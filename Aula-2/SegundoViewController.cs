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
			(tvTabela.Delegate as tvTabelaDelegate).OnInsert = () => {
				var texto = new UITextField();
				texto.Placeholder = "novo item";
				var alerta = new UIAlertView ("Novo item", "Insira o novo item", null, "OK");
				//alerta.AlertViewStyle = UIAlertViewStyle.PlainTextInput;
				alerta.AddSubview(texto);
				alerta.Show ();
				return texto.Text;
			};
				
			btnEditar.TouchUpInside += (sender, e) => {
				if (tvTabela.Editing) {
					btnEditar.SetTitle("Editar", UIControlState.Normal);
					tvTabela.SetEditing(false, true);
					(tvTabela.Delegate as tvTabelaDelegate).DidEndEditing(tvTabela);
				} else {
					btnEditar.SetTitle("OK", UIControlState.Normal);
					(tvTabela.Delegate as tvTabelaDelegate).WillBeginEditing(tvTabela);
					tvTabela.SetEditing(true, true);
				}

			};

		}
	}
}
