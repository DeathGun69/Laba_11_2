namespace KPO_laba11_2
{
    public class RhodeIslandZCreator:IFigureCreator
    {
        public IFigure figureCreate()
        {
            // Класс-создатель фигуры
            RhodeIslandZ rhodeIslandZ = new RhodeIslandZ();
            
            return rhodeIslandZ;
        }
    }    
}