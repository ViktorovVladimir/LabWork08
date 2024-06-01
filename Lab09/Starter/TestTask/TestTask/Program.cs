namespace HelloWorld
{
    public class Program
    { 
        //--.
        public static void Main(string[] args )
        {
            
            //--. первая точка
            Console.Write("Введите p1.x = ");
            double pX = Convert.ToDouble( Console.ReadLine() );
            Console.Write("Введите p1.y = ");
            double pY = Convert.ToDouble( Console.ReadLine() );
            TPoint p1 = new TPoint( pX, pY );

            //--. вторая точка
            Console.Write("Введите p2.x = ");
            pX = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите p2.y = ");
            pY = Convert.ToDouble(Console.ReadLine());
            TPoint p2 = new TPoint(pX, pY);

            //--. Третья точка
            Console.Write("Введите p3.x = ");
            pX = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите p3.y = ");
            pY = Convert.ToDouble(Console.ReadLine());
            TPoint p3 = new TPoint(pX, pY);


            //--.
            TTriangle tr = new TTriangle(p1, p2, p3);

            //--. Расчёт периметра треугольника
            double prRes = tr.Perimetr();

            //--. Расчёт площади треугольника
            double sqRes = tr.Square();

            //--. Вывести длины сторон треугольника
            var (side1Len, side2Len, side3Len) = tr.getSedeLength();


            //--. Реализовать проверку, позволяющую установить, существует ли треугольник с данными сторонами
            bool validTriangle = tr.Valid();

            //--.
            if (!validTriangle)
            {
                Console.WriteLine("Проверка сторон треугольника: Треугольника с такими сторонами НЕ СУЩЕСТВУЕТ!");
            }
            else
            {
                Console.WriteLine("Проверка сторон треугольника: треугольник сущесвует.");

                //--.
                Console.WriteLine("\tОтвет:");
                Console.WriteLine("\t------------------");
                Console.WriteLine("\tПериметр треуголиника равен  {0:F2}", prRes);
                Console.WriteLine("\tПлощадь треуголиника равна  {0:F2}", sqRes);
                Console.WriteLine("\tСтороны треугольника равны: сторона 1 =  {0:F2}, сторона 2 =  {1:F2}, сторона 3 =  {2:F2}", side1Len, side2Len, side3Len);

            }

        }

    }
}