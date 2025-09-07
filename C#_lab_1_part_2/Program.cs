class Program
{
    static int Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Please enter a numeric argument.");
            return 1;
        }

        Rectangle rect = new(double.Parse(args[0]), double.Parse(args[1]));
        Console.WriteLine($"Площадь прямоугольника: {rect.Area}\nПериметр прямоуголльника: {rect.Perimetr}\n");
        return 0;
    }
}
public class Rectangle
{
    double sideA, sideB;
    public Rectangle(double sideA, double sideB)
    {
        this.sideA = sideA;
        this.sideB = sideB;

    }
    double CalculateArea()
    {
        return sideA * sideB;
    }

    double CalculatePerimeter()
    {
        return 2 * (sideB + sideA);
    }


    public double Area { get { return CalculateArea(); } }
    public double Perimetr { get { return CalculatePerimeter(); } }
}