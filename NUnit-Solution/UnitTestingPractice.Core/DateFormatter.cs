using System.Globalization;

namespace UnitTestingPractice.Core;

public class DateFormatter
{
    public string FormatDate(string inputDate)
    {
        if (!DateTime.TryParseExact(
                inputDate,
                "yyyy-MM-dd",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out DateTime parsedDate))
        {
            throw new FormatException("Date must be in yyyy-MM-dd format.");
        }

        return parsedDate.ToString("dd-MM-yyyy", CultureInfo.InvariantCulture);
    }
}
