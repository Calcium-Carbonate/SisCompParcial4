using System;

namespace SisCompParcial4
{
    class Program
    { 
        static void Main(string[] args)
        { int choose;
            Console.WriteLine("Elige tu pokemon");
            Console.WriteLine("Charmander = 1 / Eevee = 2 / ");
            choose = int.Parse(Console.ReadLine());

            if (choose == 1)
            {
                choose = 0;
                Charmander charmander = new Charmander();
                charmander.ShowPokemon();

                Console.WriteLine("Un pokemon salvaje apareció, tu pokemon atacará");
                charmander.Attack();

                Console.WriteLine(charmander.name + " Subió de nivel");
                charmander.LevelUp();

                if (charmander.level == 16) charmander.Evolve();
                charmander = null;

            }
            if (choose == 2)
            {
                choose = 0;
                Eevee eevee = new Eevee();
                eevee.ShowPokemon();

                Console.WriteLine("Un pokemon salvaje apareció, tu pokemon atacará");
                eevee.Attack();

                Console.WriteLine(eevee.name + " Subió de nivel");
                eevee.LevelUp();

                Console.WriteLine("Encontraste una piedra fuego, se la darás a Eevee? Sí/No=1/2");
                choose = int.Parse(Console.ReadLine());
                if (choose == 1)
                {
                    eevee.haveStone = 1;
                    eevee.Evolve();
                    eevee = null;
                }
                else if (choose == 2)
                {
                    eevee.Evolve();
                }

            }


        }

    }
}

