using System;

using No5.Solution.Conventers;

namespace No5.Solution.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            DocumentPart[] parts = new DocumentPart[]
            {
                new BoldText() {Text = "BoldText"},
                new BoldText() {Text = "AnotherBoldText"},
                new PlainText() {Text = "Just a PlainText"},
                new Hyperlink() {Text = "It's hyperlink", Url = "And his url"}
            };

            Document document = new Document(parts);

            string PlainText = document.Print(new HtmlConverter());

            System.Console.WriteLine(PlainText);
            System.Console.ReadLine();
        }
    }
}
