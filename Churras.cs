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

			convidados.Add(new Convidado("Matheus",             "JÁ PAGOU", true));
			convidados.Add(new Convidado("Solange",             "JÁ PAGOU", true));
			convidados.Add(new Convidado("Cristofer",           "JÁ PAGOU", true));
			convidados.Add(new Convidado("Yuki",                "JÁ PAGOU", true));
			convidados.Add(new Convidado("Paulo",               "JÁ PAGOU", true));
			convidados.Add(new Convidado("Paulo - Esposa",      "JÁ PAGOU", true));
			convidados.Add(new Convidado("Paulo - Filha",       "JÁ PAGOU", true));
			convidados.Add(new Convidado("Paulo - Sogro",       "JÁ PAGOU", true));
			convidados.Add(new Convidado("Paulo - Sogra",       "JÁ PAGOU", true));
			convidados.Add(new Convidado("Paulo - cunhado",     "JÁ PAGOU", true));
			convidados.Add(new Convidado("João Lucas",          "JÁ PAGOU", true));
			convidados.Add(new Convidado("João Lucas - Esposa", "JÁ PAGOU", true));
			convidados.Add(new Convidado("João Lucas - Filho",  "JÁ PAGOU", true));
			convidados.Add(new Convidado("Sergio",              "JÁ PAGOU", true));
			convidados.Add(new Convidado("Sergio - Esposa",     "JÁ PAGOU", true));
			convidados.Add(new Convidado("Sergio - Filho",      "JÁ PAGOU", true));
			convidados.Add(new Convidado("Bruno",               "JÁ PAGOU", true));
			convidados.Add(new Convidado("Bruno - Esposa",      "JÁ PAGOU", true));
			convidados.Add(new Convidado("Bruno - Filha)",      "JÁ PAGOU", true));
			convidados.Add(new Convidado("Carlos",              "NÃOPAGOU", false));
			convidados.Add(new Convidado("Carlos - Esposa",     "NÃOPAGOU", false));
			convidados.Add(new Convidado("Carlos - Filha",      "NÃOPAGOU", false));
			convidados.Add(new Convidado("Carlos - Filha",      "NÃOPAGOU", false));

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
