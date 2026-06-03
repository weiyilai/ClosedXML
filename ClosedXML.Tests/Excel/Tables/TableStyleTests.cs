using NUnit.Framework;

namespace ClosedXML.Tests.Excel;

[TestFixture]
internal class TableStyleTests
{
    [Test]
    public void Load_and_save_field_differential_styles()
    {
        // Test file contains different dxf for header, data and totals of each column. The table
        // doesn't have a header, because dxf for header can be specified only when header is not
        // shown. Toggle Header Row to see the format of the header in Excel. The table should
        // have font size that increases in each table area, from 10 to 15 points.
        TestHelper.LoadSaveAndCompare(
            @"Other\Tables\TableColumnStyles-input.xlsx",
            @"Other\Tables\TableColumnStyles-output.xlsx");
    }
}
