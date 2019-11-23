namespace KPO_laba11_2
{
    public class TeeweeCreator:IFigureCreator
    {
        public IFigure figureCreate()
        {
            // Класс-создатель фигуры
            Teewee teewee = new Teewee();
            
            return teewee;
        }
    }
}