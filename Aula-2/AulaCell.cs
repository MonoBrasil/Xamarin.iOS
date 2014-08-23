using System;
using MonoTouch.UIKit;
using System.Drawing;

namespace Aula2
{
	public class AulaCell : UITableViewCell
	{
		private UILabel titulo;
		private UILabel subtitulo;
		private UIImageView foto;

		public AulaCell (string identificador) : base (UITableViewCellStyle.Default, identificador)
		{
			titulo = new UILabel ();
			titulo.Font = UIFont.FromName ("Cochin-BoldItalic", 18.0f);
			titulo.TextColor = UIColor.Red;
			subtitulo = new UILabel ();
			subtitulo.Font = UIFont.FromName("AmericanTypewriter", 14.0f);
			subtitulo.TextColor = new UIColor (0.5f, 0.5f, 0.5f, 1f);
			foto = new UIImageView ();
			foto.ContentMode = UIViewContentMode.ScaleAspectFit;

			ContentView.AddSubview (titulo);
			ContentView.AddSubview (subtitulo);
			ContentView.AddSubview (foto);
		}

		public void UpdateCell(string nome, string legenda, UIImage imagem) {
			titulo.Text = nome;
			subtitulo.Text = legenda;
			foto.Image = imagem;

		}

		public override void LayoutSubviews ()
		{
			base.LayoutSubviews ();

			titulo.Frame = new RectangleF (3, 5, ContentView.Frame.Width - 56, 22);
			subtitulo.Frame = new RectangleF (3, 28, ContentView.Frame.Width - 56, 16);
			foto.Frame = new RectangleF (ContentView.Frame.Width - 53, 5, 50, 50);
		}
	}
}

