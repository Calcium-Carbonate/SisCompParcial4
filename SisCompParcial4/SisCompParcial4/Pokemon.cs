using System;
namespace SisCompParcial4
{
	public abstract class Pokemon
	{
		public string name = string.Empty;
		public int level = 0;
		public string type = string.Empty;

		public Pokemon()
		{
			name = "";
			level = 0;
			type = "";
		}

		public virtual void Evolve()
        {
			Console.WriteLine(name + "Evolucionó");
        }

		public virtual void Attack()
		{
			Console.WriteLine(name + "Placaje");

		}

		public void ShowPokemon()
        {
			Console.WriteLine("Nombre " + name);
			Console.WriteLine("Nivel " + level);
			Console.WriteLine("Tipo" + type);
		}

		public void LevelUp()
        {
			
			this.level++;
			Console.WriteLine(this.name + " Subió a nivel " + level);
		}
		public  void LearnAttack()
		{
			Console.WriteLine("Aprendió cascada");
		}

	}

}
