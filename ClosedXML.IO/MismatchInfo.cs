namespace ClosedXML.IO;

/// <summary>
/// An info sent to the consuming application in case of a mismatch.
/// </summary>
public class MismatchInfo
{
    public int? LineNumber { get; init; }

    public int? LinePosition { get; init; }
}
