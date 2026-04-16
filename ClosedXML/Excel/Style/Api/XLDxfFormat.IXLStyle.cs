using System;

namespace ClosedXML.Excel;

internal partial class XLDxFormat : IXLStyle
{
    IXLAlignment IXLStyle.Alignment
    {
        get => Alignment;
        set => Alignment.SetValue(value);
    }

    IXLBorder IXLStyle.Border
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    IXLNumberFormat IXLStyle.DateFormat => throw new NotImplementedException();

    IXLFill IXLStyle.Fill
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    IXLFont IXLStyle.Font
    {
        get => Font;
        set => Font.SetValue(value);
    }

    bool IXLStyle.IncludeQuotePrefix
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    IXLNumberFormat IXLStyle.NumberFormat
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    IXLProtection IXLStyle.Protection
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    IXLStyle IXLStyle.SetIncludeQuotePrefix(bool includeQuotePrefix)
    {
        throw new NotImplementedException();
    }

    bool IEquatable<IXLStyle>.Equals(IXLStyle? other)
    {
        throw new NotSupportedException();
    }

    /// <summary>
    /// A helper method that is used when a style if copied from one object to another.
    /// For example, <c>conditionaFormat.Style = someOtherApi.Style</c>.
    /// </summary>
    internal void SetStyle(IXLStyle other)
    {
        // TODO Styles: Implement.
        throw new NotImplementedException();
    }
}
