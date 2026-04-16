namespace ClosedXML.Excel.Formatting;

/// <summary>
/// A differential format.
/// </summary>
internal record XLDxfValue
{
    internal static readonly XLDxfValue Empty = new()
    {
        NumberFormat = null,
        Font = XLDifferentialFontValue.Empty,
        Fill = XLDifferentialFillValue.Empty,
        Alignment = XLDifferentialAlignmentValue.Empty,
        Border = null,
        Protection = null
    };

    public required string? NumberFormat { get; init; }

    public required XLDifferentialFontValue Font { get; init; }

    public required XLDifferentialFillValue Fill { get; init; }

    public required XLDifferentialAlignmentValue Alignment { get; init; }

    public required XLBorderFormatValue? Border { get; init; }

    public required XLProtectionFormatValue? Protection { get; init; }
}
