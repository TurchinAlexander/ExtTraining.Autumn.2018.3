namespace No5.Solution.Conventers
{
    public class LaTeXConverter : IConverter
    {
        public string Convert(DocumentPart document)
        {
            if (document is BoldText)
            {
                return $"\\textbf{{{document.Text}}}";
            }
            else if (document is Hyperlink)
            {
                return $"\\href{{{(document as Hyperlink).Url}}}{{{document.Text}}}";
            }
            else if (document is PlainText)
            {
                return document.Text;
            }

            return "";
        }
    }
}