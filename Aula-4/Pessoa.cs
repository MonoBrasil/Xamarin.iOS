using System;
using SQLite.Net.Attributes;

namespace Aula4
{
	public class Pessoa
	{
		public Pessoa ()
		{
		}

		[PrimaryKey, AutoIncrement]
		public int Id { get; set; }

		[Indexed]
		public string Nome { get; set; }

		[MaxLength(13)]
		public string Telefone { get; set; }
	}
}

