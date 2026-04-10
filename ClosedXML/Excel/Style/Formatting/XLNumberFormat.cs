using System;

namespace ClosedXML.Excel;

/// <summary>
/// A strongly typed number format.
/// </summary>
internal readonly record struct XLNumberFormat
{
    private readonly string _format;

    internal XLNumberFormat(string format)
    {
        _format = format ?? throw new ArgumentNullException(nameof(format));
    }

    public string Format => _format;

    public static implicit operator string(XLNumberFormat value) => value._format;

    /// <summary>
    /// Is a number format a general number format?
    /// </summary>
    internal bool IsGeneralFormat()
    {
        // General format is an empty string.
        return _format.Length == 0;
    }

    internal static XLNumberFormat Parse(string formatCode)
    {
        // Format code was originally just a string and not checked, so keep the same semantic for now.
        return new XLNumberFormat(formatCode);
    }
}
