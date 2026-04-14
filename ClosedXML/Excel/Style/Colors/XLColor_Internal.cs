namespace ClosedXML.Excel;

public partial class XLColor
{
    internal XLColorKey Key { get; }

    private XLColor() : this(new XLColorKey())
    {
        HasValue = false;
    }

    internal XLColor(XLColorKey key)
    {
        Key = key;
        HasValue = true;
    }

    /// <summary>
    /// Is the color zero-value? Zero value structures can in some cases be omitted from saving to a file.
    /// </summary>
    internal bool IsArgbZero => ColorType == XLColorType.Color && Key.Color.ToArgb() == 0x000000;
}
