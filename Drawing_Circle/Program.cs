namespace Drawing_Circle;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Lutfen cemberin yaricapini giriniz: ");
        double yaricap = double.Parse(Console.ReadLine());

        Circle.drawing_circle(yaricap);
    }
}
