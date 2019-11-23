namespace KPO_laba11_2
{
    public class HeroCreator:IFigureCreator
    {
        public IFigure figureCreate()
        {
            // Класс-создатель фигуры
            Hero hero = new Hero();
            
            return hero;
        }
    }
}