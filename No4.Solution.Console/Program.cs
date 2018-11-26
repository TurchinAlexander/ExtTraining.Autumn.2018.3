namespace No4.Solution.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseFileGenerator bytesGenerator = new RandomBytesFileGenerator();
            bytesGenerator.GenerateFiles(1, 10);

            BaseFileGenerator charsGenerator = new RandomCharsFileGenerator();
            charsGenerator.GenerateFiles(1, 10);
        }
    }
}
