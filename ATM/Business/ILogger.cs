namespace ATM
{
    internal interface ILogger
    {
        public void WriteFile(string message);
        public void EndOfTheDayReadFile();
    }
}