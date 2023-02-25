namespace Shapes;

public class Square
{
    public static void selection()
    {
        Console.WriteLine("(1) Area Calculation");
        Console.WriteLine("(2) Perimeter Calculation");
        Console.WriteLine("---------------------------------");
        Console.Write("Please select what you want to calculate: ");
        int selection = Convert.ToInt32(Console.ReadLine());

        Console.Write("Please enter line: ");
        int Line = Convert.ToInt32(Console.ReadLine());

        switch (selection)
        {
            case 1:
                Console.WriteLine("The area of your shape = " + areaCalculation(Line));
                break;
            case 2:
                Console.WriteLine("The perimeter of your shape = " + perimeterCalculation(Line));
                break;
        }
    }

    public static int areaCalculation(int Line)
    {
        int Area = Line*Line;    
        return Area;
    }
    public static int perimeterCalculation(int Line)
    {
        int Perimeter = 4*Line;    
        return Perimeter;
    }
}