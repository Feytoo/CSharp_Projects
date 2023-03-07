using BarcodeLib;
namespace Barcode_Generator;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please select= \n1-Barcode Create \n2-Barcode Read \n3-Exit");
        int input = Convert.ToInt32(Console.ReadLine());
        switch (input)
        {
            case 1:
                Barcoder.barcodeCreate();
                break;
            case 2:
                Barcoder.barcodeRead();
                break;
            case 3:
                break;
        }
    }
}
