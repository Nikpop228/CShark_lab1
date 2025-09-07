
class Program
{
    static int Main()
    {
        //Point[] points;
        //for (int i = 0; i < 5; i++)
        //{
        //    points[i] = new Point(Random() % 50, Random() % 50);
        //}
        Point p1 = new Point(5, 10);
        Point p2 = new Point(6, 11);
        Point p3 = new Point(0, 10);
        Point p4 = new Point(7, 1);
        Point p5 = new Point(4, 25);
        Figure fig = new(p1, p2, p3, p4, p5);
        Console.WriteLine($"Многоугольник: {fig.Name}\nПериметр фигуры: {fig.PerimeterCalculator()}");
        return 0;
    }
}

public class Point
{
    int x;
    int y;
    public int X { get { return x; } }
    public int Y { get { return y; } }


    public Point(int x, int y) { this.x = x;  this.y = y; }


}

public class Figure
{
    List<Point> points = new();

    public string Name { get; }
    public Figure(params Point[] param)
    {
        foreach (Point p in param)
        { 
            points.Add(p);
        }
        this.Name = "Треугольник";
    }
    public Figure(Point p1, Point p2, Point p3, Point p4) : this(p1, p2, p3)
    {
        points.Add(p4);
        this.Name = "Прямоугольник";
    }
    public Figure(Point p1, Point p2, Point p3, Point p4, Point p5) : this(p1, p2, p3, p4)
    {
        points.Add(p5);
        this.Name = "Пятиугольник";
    }
    public double LengthSide(Point A, Point B)
    {
        double a = A.X - B.X;
        double b = A.Y - B.Y;
        return Math.Sqrt(a * a + b * b);
    }

    public double PerimeterCalculator()
    {
        double perimetr = 0;
        for(int i = 0; i < points.Count - 1; i++)
        {
            perimetr += this.LengthSide(this.points[i], this.points[i+1]);
        }
        perimetr += this.LengthSide(this.points[0], this.points[points.Count-1]);
        return perimetr;
    }
}