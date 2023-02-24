namespace Drawing_Circle;

public class Circle
{
    public static void drawing_circle(double yaricap)
    {
        for (double y = -yaricap; y <= yaricap; y++)
            {
                for (double x = -yaricap; x <= yaricap; x += 0.5)
                {
                    if (x * x + y * y >= yaricap * yaricap)
                    {
                        Console.Write("-");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
    }
}