namespace Drawing_Triangle;

public class Triangle
{
    public static void drawing_triangle(int kenar)
    {
        int i,j,k;

        for (i=0; i<=kenar; i++)
        {
            for (j=0; j<=kenar; j++)
            {
                Console.Write("");
            }
            for (k=0; k<i; k++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}