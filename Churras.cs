namespace Churras
{
	public class Convidado
	{
		public string nome { get; set; }
		public string status { get; set; }
		public bool pagou { get; set; }
		
		public Convidado(string nome, string status, bool pagou)
		{
		    this.nome = nome;
		    this.status = status;
		    this.pagou = pagou;
		}

		public void PodeEntrar() { }
	}

	public class ChurrasService
	{
		private void ExecutaChurrasPaulao()
		{
			var convidados = new List<Convidado>();

			// CONFIRMADOS
			convidados.Add(new Convidado("Matheus",             "confirmado", true));
			convidados.Add(new Convidado("Cristofer",           "confirmado", false));
			convidados.Add(new Convidado("João Lucas",          "confirmado", false));
			convidados.Add(new Convidado("João Lucas - Esposa", "confirmado", false));
			convidados.Add(new Convidado("João Lucas - Filho",  "confirmado", false));
			convidados.Add(new Convidado("Bruno",               "confirmado", false));
			convidados.Add(new Convidado("Bruno - Esposa",      "confirmado", false));
			convidados.Add(new Convidado("Bruno - Filha)",      "confirmado", false));
			convidados.Add(new Convidado("Carlos",              "confirmado", false));
			convidados.Add(new Convidado("Carlos - Esposa",     "confirmado", false));
			convidados.Add(new Convidado("Carlos - Filha",      "confirmado", false));
			convidados.Add(new Convidado("Carlos - Filha",      "confirmado", false));

			// INTERESSADOS
			convidados.Add(new Convidado("Tiago Altomare", "interassado", false));
			convidados.Add(new Convidado("Rafael",         "interassado", false));
			convidados.Add(new Convidado("Sergio",         "interassado", false));
			convidados.Add(new Convidado("Yuki",           "interassado", false));
			convidados.Add(new Convidado("Solange",        "interassado", false));
			convidados.Add(new Convidado("João Darci",     "interassado", false));



			if (DateTime.Now == new DateTime(2022,04,02))
			{
				foreach (var convidado in convidados)
					if (convidado.pagou == true)
						convidado.PodeEntrar();
			}

			return;
		}
	}
}
