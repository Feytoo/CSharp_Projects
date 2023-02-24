namespace Algorithm;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Lutfen istediginiz kelimeyi ve silmek istediginiz index'i giriniz.(Arada virgul bulundurun!): ");
        string input = Console.ReadLine();

        Console.WriteLine($"Yeni kelimeniz = {Algoritma.write_word(input)}");
    }
}
