#pragma warning disable CA1303
#pragma warning disable CS8600
#pragma warning disable CS8603

namespace ProgrammingLabs.Utilities;

public static class IOUtils
{
    public static void SetExtValues (IDictionary<string, string> values)
    {
        ExternalValues = values;
    }
    internal static IDictionary<string, string>? ExternalValues
    {
        get; private set;
    }

    internal static void WaitForKey ()
    {
        if (ExternalValues != null)
        {
            return;
        }
        else
        {
            Console.WriteLine("Press Enter To Continue");
            _ = Console.ReadLine();
            Console.Clear();
        }
    }

    internal static string GetLine (string paramName, string message)
    {
        if (!string.IsNullOrEmpty(message) && ExternalValues == null)
        {
            Console.WriteLine(message);
        }

        if (ExternalValues != null && !string.IsNullOrEmpty(paramName))
        {
            return ExternalValues [paramName];
        }
        else
        {
            return Console.ReadLine();
        }
    }

    public static bool ParseInt (string sValue, out int iValue)
    {
        if (int.TryParse(sValue, out iValue))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static int GetInt (string paramName, string message)
    {
        while (true)
        {
            string sValue = GetValue(paramName, message);
            if (ParseInt(sValue, out int iValue) == true)
            {
                return iValue;
            }

            Console.WriteLine("Parsing Error. Enter Other Value. Format Int32: ");
        }
    }

    public static bool ParseDate (string sValue, out DateTime date)
    {
        if (DateTime.TryParseExact(sValue, "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out date))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    internal static DateTime GetDate (string paramName, string message)
    {
        while (true)
        {
            string sValue = GetValue(paramName, message);
            if (ParseDate(sValue, out DateTime date) == true)
            {
                return date;
            }

            Console.WriteLine("Parsing Error. Enter Other Value. Format dd.mm.yyyy");
        }
    }

    public static DateTime GetMinTime (DateTime d1, DateTime d2)
    {
        if (d1 < d2)
        {
            return d1;
        }
        else
        {
            return d2;
        }
    }
    public static DateTime GetMaxTime (DateTime d1, DateTime d2)
    {
        if (d2 > d1)
        {
            return d2;
        }
        else
        {
            return d1;
        }
    }

    public static int GetIntersection (DateTime a1, DateTime b1, DateTime a2, DateTime b2)
    {
        // arranging segments
        if (a1 > b1)
        {
            (a1, b1) = (b1, a1);
        }

        if (a2 > b2)
        {
            (a2, b2) = (b2, a2);
        }

        int iDaysDiff = (GetMinTime(b1, b2) - GetMaxTime(a1, a2)).Days;
        if (iDaysDiff < 0)
        {
            return 0;
        }
        else
        {
            return iDaysDiff + 1;
        }
    }

    private static string GetValue (string paramName, string message)
    {
        if (!string.IsNullOrEmpty(message) && ExternalValues == null)
        {
            Console.WriteLine(message);
        }

        string sValue;
        if (ExternalValues == null)
        {
            sValue = GetLine("", "");
        }
        else
        {
            if (!ExternalValues.TryGetValue(paramName, out sValue))
            {
                throw new InvalidOperationException($"Parameter -{paramName} Not Specified ");
            }
        }

        return sValue;
    }
}