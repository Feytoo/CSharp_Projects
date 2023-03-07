using BarcodeLib;
using System.Drawing;
using System.Drawing.Imaging;
namespace Barcode_Generator;

public class Barcoder
{
    static TYPE type = BarcodeLib.TYPE.PHARMACODE;
    public static Barcode barcodeCreate()
    {
        Console.Write("Please enter numeric to generate barcode: ");
        string input = Console.ReadLine();

        Barcode barcode = new Barcode(input , type);

        barcode.SaveImage(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\barcode.png", BarcodeLib.SaveTypes.PNG);

        return barcode;
    }

    public static string barcodeRead()
    {
        //return "Barcode value = " + barcode.RawData + " \n";
        return "hehehe";
    }
    
}