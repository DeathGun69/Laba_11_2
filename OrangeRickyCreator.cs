namespace KPO_laba11_2
{
    public class OrangeRickyCreator:IFigureCreator
    {
        public IFigure figureCreate()
        {
            // Класс-создатель фигуры
            OrangeRicky orangeRicky = new OrangeRicky();
            
            return orangeRicky;
        }
    }
}