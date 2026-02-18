namespace ClosedXML.Excel.Formatting;

/// <summary>
/// A border format master record.
/// </summary>
internal record XLBorderFormatValue
{
    internal static readonly XLBorderFormatValue None = new()
    {
        Left = XLBorderLine.None,
        Right = XLBorderLine.None,
        Top = XLBorderLine.None,
        Bottom = XLBorderLine.None,
        Diagonal = XLBorderLine.None,
        Vertical = XLBorderLine.None,
        Horizontal = XLBorderLine.None,
        DiagonalUp = false,
        DiagonalDown = false,
        Outline = false
    };

    public required XLBorderLine Left { get; init; }

    public required XLBorderLine Right { get; init; }

    public required XLBorderLine Top { get; init; }

    public required XLBorderLine Bottom { get; init; }

    /// <summary>
    /// Used when <see cref="DiagonalUp"/> or <see cref="DiagonalDown"/> are set. It's not possible
    /// to have different style for up/down diagonal.
    /// </summary>
    public required XLBorderLine Diagonal { get; init; }

    /// <summary>
    /// For pivot tables only.
    /// </summary>
    public required XLBorderLine Vertical { get; init; }

    /// <summary>
    /// For pivot tables only.
    /// </summary>
    public required XLBorderLine Horizontal { get; init; }

    public required bool DiagonalUp { get; init; }

    public required bool DiagonalDown { get; init; }

    public required bool Outline { get; init; }
}
