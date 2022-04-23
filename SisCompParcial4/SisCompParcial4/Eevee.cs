using System;
namespace SisCompParcial4
{
	public class Eevee:Pokemon
	{
		public int haveStone = 0;
		public Eevee()
		{
			this.name = "Eevee";
			this.level = 10;
			this.type = "Normal";
			haveStone = 0;
		}

		public override void Attack()
		{
			Console.WriteLine(name + " usó Arañazo");
		}

		public override void Evolve()
		{
            if (haveStone == 1)
            {
				Console.WriteLine(name + " Evolucionó");

				Jolteon jolteon = new Jolteon(level);
			}

            else
            {
				Console.WriteLine("No le diste la piedra a Eevee entonces no evolucionó");
            }

		}
	}
}