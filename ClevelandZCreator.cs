namespace KPO_laba11_2
{
    public class ClevelandZCreator:IFigureCreator
    {
        public IFigure figureCreate()
        {
            // Класс-создатель фигуры
            ClevelandZ clevelandZ = new ClevelandZ();
            
            return clevelandZ;
        }
    }
}