namespace Shapes;

public class Triangle
{
    public static void selection()
    {
        Console.WriteLine("(1) Area Calculation");
        Console.WriteLine("(2) Perimeter Calculation");
        Console.WriteLine("---------------------------------");
        Console.Write("Please select what you want to calculate: ");
        int selection = Convert.ToInt32(Console.ReadLine());

        Console.Write("Please enter base line: ");
        int baseLine = Convert.ToInt32(Console.ReadLine());
        Console.Write("Please enter height: ");
        int height = Convert.ToInt32(Console.ReadLine());

        switch (selection)
        {
            case 1:
                Console.WriteLine("The area of your shape = " + areaCalculation(baseLine,height));
                break;
            case 2:
                Console.WriteLine("The perimeter of your shape = " + perimeterCalculation(baseLine));
                break;
        }
    }

    public static int areaCalculation(int baseLine, int height)
    {
        int Area = (baseLine*height)/2;    
        return Area;
    }
    public static int perimeterCalculation(int baseLine)
    {
        int Perimeter = 3*baseLine;    
        return Perimeter;
    }
}