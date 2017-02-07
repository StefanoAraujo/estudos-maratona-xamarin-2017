using System;
using System.Linq;
using System.Collections.Generic;

namespace EstudantesXamarinForms
{
	public class EstudanteServices
	{
		// TODO: Criar uma API para consumir informações
		// ...
		private static List<EstudanteModel> _estudantes = new List<EstudanteModel>();

		public static IEnumerable<EstudanteModel> Get()
		{
			_estudantes.Clear();

			_estudantes.Add(new EstudanteModel { ID = Guid.NewGuid().ToString(), Nome = "Thiago Souza", Twitter = "@thiagorodsouza", ImagemUrl = "https://blog.xamarin.com/wp-content/uploads/2015/03/RDXWoY7W_400x400.png" });
			_estudantes.Add(new EstudanteModel { ID = Guid.NewGuid().ToString(), Nome = "Vinicius Silva", Twitter = "@viniborges", ImagemUrl = "https://blog.xamarin.com/wp-content/uploads/2015/03/RDXWoY7W_400x400.png" });
			_estudantes.Add(new EstudanteModel { ID = Guid.NewGuid().ToString(), Nome = "Max Kikuchi", Twitter = "@max_kikuchi", ImagemUrl = "https://blog.xamarin.com/wp-content/uploads/2015/03/RDXWoY7W_400x400.png" });
			_estudantes.Add(new EstudanteModel { ID = Guid.NewGuid().ToString(), Nome = "Leonardo Soares", Twitter = "N/A", ImagemUrl = "https://blog.xamarin.com/wp-content/uploads/2015/03/RDXWoY7W_400x400.png" });
			_estudantes.Add(new EstudanteModel { ID = Guid.NewGuid().ToString(), Nome = "Fernando Ferri", Twitter = "N/A", ImagemUrl = "https://blog.xamarin.com/wp-content/uploads/2015/03/RDXWoY7W_400x400.png" });
			_estudantes.Add(new EstudanteModel { ID = Guid.NewGuid().ToString(), Nome = "Gabriel Toledo", Twitter = "@FalleNCS", ImagemUrl = "https://blog.xamarin.com/wp-content/uploads/2015/03/RDXWoY7W_400x400.png" });
			_estudantes.Add(new EstudanteModel { ID = Guid.NewGuid().ToString(), Nome = "Bill Gates", Twitter = "@BillGates", ImagemUrl = "https://blog.xamarin.com/wp-content/uploads/2015/03/RDXWoY7W_400x400.png" });
			_estudantes.Add(new EstudanteModel { ID = Guid.NewGuid().ToString(), Nome = "BarackObama", Twitter = "@BarackObama", ImagemUrl = "https://blog.xamarin.com/wp-content/uploads/2015/03/RDXWoY7W_400x400.png" });
			_estudantes.Add(new EstudanteModel { ID = Guid.NewGuid().ToString(), Nome = "Oprah Winfrey", Twitter = "@Oprah", ImagemUrl = "https://blog.xamarin.com/wp-content/uploads/2015/03/RDXWoY7W_400x400.png" });
			_estudantes.Add(new EstudanteModel { ID = Guid.NewGuid().ToString(), Nome = "Felipe Castanhari", Twitter = "@FeCastanhari", ImagemUrl = "https://blog.xamarin.com/wp-content/uploads/2015/03/RDXWoY7W_400x400.png" });
			_estudantes.Add(new EstudanteModel { ID = Guid.NewGuid().ToString(), Nome = "Terry Crews", Twitter = "@terrycrews", ImagemUrl = "https://blog.xamarin.com/wp-content/uploads/2015/03/RDXWoY7W_400x400.png" });

			return _estudantes.OrderBy(estudante => estudante.Nome);
		}

		public static IEnumerable<EstudanteModel> Delete(EstudanteModel model)
		{
			_estudantes.Remove(model);
			return _estudantes.OrderBy(estudante => estudante.Nome);
		}
	}
}
