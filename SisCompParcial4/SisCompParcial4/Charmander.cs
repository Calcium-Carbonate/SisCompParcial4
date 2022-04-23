using System;
namespace SisCompParcial4
{
	public class Charmander : Pokemon
	{
		public Charmander()
		{
			this.name = "Charmander";
			this.level = 15;
			this.type = "Fuego";
		}

		public override void Attack()
        {
			Console.WriteLine(name + " usó ascuas");
        }

		public override void Evolve()
        {
            if (this.level == 16)
            {
				Console.WriteLine(name + " Evolucionó");

				Charmeleon charmeleon = new Charmeleon(level);

			}

			else
            {
				Console.WriteLine(name + "No Evolucionó");
			}
		}
    }
}

