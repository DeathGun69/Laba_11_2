using System;

namespace KPO_laba11_2
{
    class Program
    {
        static void Main(string[] args)
        {
            TeeweeCreator teeweeCreator = new TeeweeCreator();
            SmashboyCreator smashboyCreator = new SmashboyCreator();
            RhodeIslandZCreator rhodeIslandZCreator = new RhodeIslandZCreator();
            OrangeRickyCreator orangeRickyCreator = new OrangeRickyCreator();
            HeroCreator heroCreator = new HeroCreator();
            ClevelandZCreator clevelandZCreator = new ClevelandZCreator();
            BlueRickyCreator blueRickyCreator = new BlueRickyCreator();

            Random rnd = new Random();
            int value = rnd.Next(1, 8);
            Console.WriteLine();

            switch (value)
            {
                case 1:
                    Console.WriteLine(teeweeCreator.figureCreate().getName());
                    break;
                case 2:
                    Console.WriteLine(smashboyCreator.figureCreate().getName());
                    break;
                case 3:
                    Console.WriteLine(rhodeIslandZCreator.figureCreate().getName());
                    break;
                case 4:
                    Console.WriteLine(orangeRickyCreator.figureCreate().getName());
                    break;
                case 5:
                    Console.WriteLine(heroCreator.figureCreate().getName());
                    break;
                case 6:
                    Console.WriteLine(clevelandZCreator.figureCreate().getName());
                    break;
                case 7:
                    Console.WriteLine(blueRickyCreator.figureCreate().getName());
                    break;
                case 8:
                    Console.WriteLine("Super Figura");
                    break;
                default:
                    Console.WriteLine("Error!!!");
                    break;
            }
        }
    }
}
