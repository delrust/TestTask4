//Задание:
//Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга
//по радиусу и треугольника по трем сторонам. Дополнительно к работоспособности оценим
//Легкость добавления других фигур
//Вычисление площади фигуры без знания типа фигуры в compile-time
//Проверку на то, является ли треугольник прямоугольным

public abstract class Figure
{
    public abstract double Sqare();
}

public class Circl : Figure
{
    private double Radius { get; set; }

    public Circl(double radius)
    {
        Radius = radius;
    }

    public override double Sqare()
    {
        return 2 * Math.PI * Radius * Radius;
    }
    public double Sqare(double radius)
    {
        Radius = radius;
        return Sqare();
    }
}

public class Triangle : Figure
{
    double a { get; set; }
    double b { get; set; }
    double c { get; set; }

    public Triangle(double a, double b, double c)
    {
        this.a = a; this.b = b; this.c = c;
    }

    public override double Sqare()
    {
        double p = 0.5f * (a + b + c);
        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }

    public bool isRectTriangle(double a, double b, double c)
    {
        if (b > a && b > c)
        {
            double temp = a;
            a = b;
            b = temp;
        }
        else if (c > a && c > b)
        {
            double temp = a;
            a = c;
            c = temp;
        }
        if (b * b + c * c == a * a) return true;
        else return false;
    }
    public bool isRectTriangle()
    {
        return isRectTriangle(a, b, c);
    }
}