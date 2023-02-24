namespace Reverse_Word;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ters cevirmek istediginiz cumleyi giriniz: ");
        string cumle = Console.ReadLine();

        Console.WriteLine(Reverse.reverse_word(cumle));
    }
}
