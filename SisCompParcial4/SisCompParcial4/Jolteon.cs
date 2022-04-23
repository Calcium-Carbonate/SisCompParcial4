using System;
namespace SisCompParcial4
{
	public class Jolteon : Eevee
	{
		public Jolteon(int level)
		{
			this.name = "Jolteon";
			this.level = level;
			this.type = "Electrico";
			ShowPokemon();
		}

	}
}