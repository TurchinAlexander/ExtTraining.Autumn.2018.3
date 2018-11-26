namespace No5.Solution.Conventers
{
    public class HtmlConverter : IConverter
    {
        public string Convert(DocumentPart document)
        {
            if (document is BoldText)
            {
                return $"<b>{document.Text}</b>";
            }
            else if (document is Hyperlink)
            {
                return $"<a href=\"{(document as Hyperlink).Url}\">{document.Text}</a>";
            }
            else if (document is PlainText)
            {
                return document.Text;
            }

            return "";
        }
    }
}
