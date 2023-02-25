namespace Shapes;

public class Rectangle
{
    public static void selection()
    {
        Console.WriteLine("(1) Area Calculation");
        Console.WriteLine("(2) Perimeter Calculation");
        Console.WriteLine("---------------------------------");
        Console.Write("Please select what you want to calculate: ");
        int selection = Convert.ToInt32(Console.ReadLine());

        Console.Write("Please enter short line: ");
        int shortLine = Convert.ToInt32(Console.ReadLine());
        Console.Write("Please enter long line: ");
        int longLine = Convert.ToInt32(Console.ReadLine());

        switch (selection)
        {
            case 1:
                Console.WriteLine("The area of your shape = " + areaCalculation(shortLine,longLine));
                break;
            case 2:
                Console.WriteLine("The perimeter of your shape = " + perimeterCalculation(shortLine,longLine));
                break;
        }
    }

    public static int areaCalculation(int shortLine, int longLine)
    {
        int Area = shortLine*longLine;    
        return Area;
    }
    public static int perimeterCalculation(int shortLine, int longLine)
    {
        int Perimeter = (2*shortLine) + (2*longLine);    
        return Perimeter;
    }
}