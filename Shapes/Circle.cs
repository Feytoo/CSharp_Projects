namespace Shapes;

public class Circle
{
    public static void selection()
    {
        Console.WriteLine("(1) Area Calculation");
        Console.WriteLine("(2) Perimeter Calculation");
        Console.WriteLine("---------------------------------");
        Console.Write("Please select what you want to calculate: ");
        int selection = Convert.ToInt32(Console.ReadLine());

        Console.Write("Please enter radius : ");
        int radius = Convert.ToInt32(Console.ReadLine());
        double pi = 3.14;

        switch (selection)
        {
            case 1:
                Console.WriteLine("The area of your shape = " + areaCalculation(radius,pi));
                break;
            case 2:
                Console.WriteLine("The perimeter of your shape = " + perimeterCalculation(radius,pi));
                break;
        }
    }

    public static double areaCalculation(int radius,double pi)
    {
        double Area = pi*(radius*radius);    
        return Area;
    }
    public static double perimeterCalculation(int radius,double pi)
    {
        double Perimeter = 2*pi*radius;    
        return Perimeter;
    }
}