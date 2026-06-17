using System.Xml;

namespace ClosedXML.IO;

internal static class XmlReaderExtension
{
    public static (int? Line, int? Position) GetLineInfo(this XmlReader reader)
    {
        if (reader is IXmlLineInfo lineInfo && lineInfo.HasLineInfo())
            return (lineInfo.LineNumber, lineInfo.LinePosition);

        return (null, null);
    }
}
