namespace Average_Calculate;

public class Fibonacci
{
    public static int fibonacci_calculate(int depth)
    {
        int n1=0,n2=1,n3=0,sonuc=1;
        for (int i=1; i<depth; i++)
        {
            n3 = n1 + n2;
            n1 = n2;
            n2 = n3;
            sonuc += n3;
        }
        
        return sonuc;
    }

    public static double fibonacci_average(int depth)
    {
        return fibonacci_calculate(depth)/depth;
    }
}