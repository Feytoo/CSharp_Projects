namespace Drawing_Triangle;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Lutfen ucgenin yuksekligini giriniz: ");
        int kenar = Convert.ToInt32(Console.ReadLine());

        Triangle.drawing_triangle(kenar);        
    }
}
