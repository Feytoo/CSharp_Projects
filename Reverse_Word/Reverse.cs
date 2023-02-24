namespace Reverse_Word;

public class Reverse
{
    public static string reverse_word(string cumle)
    {
        string yeniCumle = "";
        string harfTutucu = "";

        for(int i =0; i <= cumle.Length; i++)
        {
            if (i == 0)
            {
                harfTutucu = cumle[i].ToString();
            }
            else if (i == cumle.Length)
            {
                yeniCumle += harfTutucu;
            }
            else if (cumle[i-1].ToString() == " ")
            {
                continue;
            }
            else if (cumle[i].ToString() == " ")
            {
                yeniCumle += harfTutucu + " ";
                harfTutucu = cumle[i+1].ToString();
            }
            else
            {
                yeniCumle += cumle[i].ToString();
            }
        }
        return yeniCumle;
    }
}