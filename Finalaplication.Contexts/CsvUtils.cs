using System.Globalization;

namespace Finalaplication.Contexts
{
    public static class CsvUtils
    {
        public static readonly string CsvSeparator = CultureInfo.CurrentCulture.TextInfo.ListSeparator;
    }
}