namespace Shapes;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("(1) Rectangle ");
        Console.WriteLine("(2) Square ");
        Console.WriteLine("(3) Triangle ");
        Console.WriteLine("(4) Circle ");
        Console.WriteLine("---------------------");
        Console.Write("Please select your shape to calculate = ");
        int shape = Convert.ToInt32(Console.ReadLine());

        switch (shape)
        {
            case 1:
                Rectangle.selection(); 
                break;
            
            case 2:
                Square.selection(); 
                break;
            
            case 3:
                Triangle.selection(); 
                break;
            
            case 4:
                Circle.selection(); 
                break;
        }
    }
}
