using System;
using System.Collections.Generic;

namespace EstudantesXamarinForms
{
	public class EstudanteServices
	{
		public static IEnumerable<EstudanteModel> Get()
		{
			var estudantes = new List<EstudanteModel>();
			estudantes.Add(new EstudanteModel { ID = Guid.NewGuid().ToString(), Nome = "Thiago Souza", Twitter = "@thiagorodsouza", ImagemUrl = "https://pbs.twimg.com/profile_images/799821299434590208/Zgkm8Xjj.jpg" });
			estudantes.Add(new EstudanteModel { ID = Guid.NewGuid().ToString(), Nome = "Vinicius Silva", Twitter = "@viniborges", ImagemUrl = "https://pbs.twimg.com/profile_images/827955569134882817/vzzdO8TI.jpg" });
			estudantes.Add(new EstudanteModel { ID = Guid.NewGuid().ToString(), Nome = "Max Kikuchi", Twitter = "@max_kikuchi", ImagemUrl = "https://pbs.twimg.com/profile_images/827955720310095876/4DAjtyP0.jpg" });

			return estudantes;
		}
	}
}
