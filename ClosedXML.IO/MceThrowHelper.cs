using System;
using System.Xml;

namespace ClosedXML.IO;

internal class MceThrowHelper
{
    public static Exception NamespacePrefixNotFound(string attributeName, string prefix, XmlReader reader)
    {
        return PartStructureException.MceError(reader, $"Attribute {attributeName} contains a namespace prefix {prefix} without a resolvable namespace.");
    }

    public static Exception MceNamespaceNotAllowed(string attributeName, XmlReader reader)
    {
        return PartStructureException.MceError(reader, $"Attribute {attributeName} contains namespace prefix for MCE, but that namespace is not allowed.");
    }

    public static Exception AttributeNamespaceNotIgnorable(string attributeName, string ns, XmlReader reader)
    {
        return PartStructureException.MceError(reader, $"Attribute {attributeName} contains namespace {ns} that is not ignorable.");
    }

    public static Exception ElementNotIgnorable(string localName, XmlReader reader)
    {
        return PartStructureException.MceError(reader, $"Element {localName} must be from ignorable namespace, but isn't.");
    }

    public static Exception InvalidAttribute(string attributeName, XmlReader reader)
    {
        return PartStructureException.MceError(reader, $"Attribute {attributeName} contains invalid value.");
    }

    public static Exception UnexpectedElementFound(string elementName, XmlReader reader)
    {
        return PartStructureException.MceError(reader, $"Found unexpected element {elementName}.");
    }
}
