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
			var convidados = new List<Convidado>(22);

			convidados.Add(new Convidado("Matheus",             "confirmado", true));
			convidados.Add(new Convidado("Solange",             "confirmada", true));
			convidados.Add(new Convidado("Cristofer",           "confirmado", true));
			convidados.Add(new Convidado("Yuki",                "confirmada", true));
			convidados.Add(new Convidado("Paulo",               "confirmado", true));
			convidados.Add(new Convidado("Paulo - Esposa",      "confirmada", true));
			convidados.Add(new Convidado("Paulo - Filha",       "confirmada", true));
			convidados.Add(new Convidado("Paulo - Sogro",       "confirmado", true));
			convidados.Add(new Convidado("Paulo - Sogra",       "confirmada", true));
			convidados.Add(new Convidado("Paulo - cunhado",     "confirmada", true));
			convidados.Add(new Convidado("João Lucas",          "confirmado", true));
			convidados.Add(new Convidado("João Lucas - Esposa", "confirmada", true));
			convidados.Add(new Convidado("João Lucas - Filho",  "confirmado", true));
			convidados.Add(new Convidado("Sergio",              "confirmado", true));
			convidados.Add(new Convidado("Sergio - Esposa",     "confirmada", true));
			convidados.Add(new Convidado("Sergio - Filho",      "confirmado", true));
			convidados.Add(new Convidado("Bruno",               "confirmado", true));
			convidados.Add(new Convidado("Bruno - Esposa",      "confirmada", true));
			convidados.Add(new Convidado("Bruno - Filha)",      "confirmada", true));
			convidados.Add(new Convidado("Carlos",              "confirmado", false));
			convidados.Add(new Convidado("Carlos - Esposa",     "confirmada", false));
			convidados.Add(new Convidado("Carlos - Filha",      "confirmada", false));
			convidados.Add(new Convidado("Carlos - Filha",      "confirmada", false));

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
