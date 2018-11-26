using System;
using System.Collections.Generic;

using No5.Solution.Conventers;

namespace No5.Solution
{
    public class Document
    {
        private readonly List<DocumentPart> parts;

        public Document(IEnumerable<DocumentPart> parts)
        {
            if (parts == null)
            {
                throw new ArgumentNullException(nameof(parts));
            }
            this.parts = new List<DocumentPart>(parts);
        }

        public string Print(IConverter converter)
        {
            string output = string.Empty;

            foreach (DocumentPart part in this.parts)
            {
                output += converter.Convert(part);
            }

            return output;
        }
    }
}
