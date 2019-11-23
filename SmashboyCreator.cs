namespace KPO_laba11_2
{
    public class SmashboyCreator:IFigureCreator
    {
        public IFigure figureCreate()
        {
            // Класс-создатель фигуры
            Smashboy smashboy = new Smashboy();
            
            return smashboy;
        }
    }
}