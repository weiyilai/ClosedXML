using System;
using System.Xml;

namespace ClosedXML.IO;

/// <summary>
/// A simplified XML reader that reads the content and hides full complexity the <see cref="XmlReader"/>.
/// </summary>
public interface IXmlTreeReader : IDisposable
{
    /// <summary>
    /// Read next node. If no more nodes can be read, return <c>false</c>.
    /// </summary>
    bool Read();

    /// <summary>
    /// A node reader is currently on.
    /// </summary>
    XmlTreeNodeType NodeType { get; }

    /// <summary>
    /// Name of an open/close element. If not on an element, return an empty string.
    /// </summary>
    /// <remarks>The name is atomized.</remarks>
    string LocalName { get; }

    /// <summary>
    /// Namespace of an open/close element. If not on an element, return an empty string.
    /// </summary>
    /// <remarks>The namespace is atomized.</remarks>
    string NamespaceUri { get; }

    /// <summary>
    /// Value of a <see cref="XmlTreeNodeType.Text"/> node. Empty string for other node types.
    /// </summary>
    string Value { get; }

    /// <summary>
    /// Get attribute value. If attribute is not found or reader is not on open element, return null.
    /// </summary>
    string? GetAttribute(string attributeName, string? namespaceUri);
}
