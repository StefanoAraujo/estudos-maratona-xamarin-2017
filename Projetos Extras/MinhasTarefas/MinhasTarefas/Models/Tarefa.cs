using System;

namespace MinhasTarefas
{
	public class Tarefa
	{
		[SQLite.PrimaryKey]
		public Guid ID { get; set; }
		public string Titulo { get; set; }
		public string Notas { get; set; }
		public bool Concluida { get; set; }
	}
}
