namespace No5.Solution.Conventers
{
    public class PlainTextConverter : IConverter
    {
        public string Convert(DocumentPart document)
        {
            if (document is BoldText)
            {
                return $"**{document.Text}**";
            }
            else if (document is Hyperlink)
            {
                return $"{document.Text}[{(document as Hyperlink).Url}]";
            }
            else if (document is PlainText)
            {
                return document.Text;
            }

            return "";
        }
    }
}
