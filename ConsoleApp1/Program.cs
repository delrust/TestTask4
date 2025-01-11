using System.Net.Http.Headers;

//namespace TestTask4;
internal class Program
{
    private static void Main(string[] args)
    {
        Circl s = new Circl(4);
        Triangle triangle = new Triangle(3,4,5);
        Figure a = s;
        Figure b = triangle;
        Console.WriteLine(a.Sqare());
        Console.WriteLine(b.Sqare());
        Console.WriteLine(triangle.isRectTriangle());
    }
}