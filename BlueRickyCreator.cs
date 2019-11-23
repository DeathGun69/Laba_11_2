namespace KPO_laba11_2
{
    public class BlueRickyCreator:IFigureCreator
    {
        public IFigure figureCreate()
        {
            // Класс-создатель фигуры
            BlueRicky blueRicky = new BlueRicky();
            
            return blueRicky;
        }
    }
}