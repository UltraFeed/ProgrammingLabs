using ProgrammingLabs.Utilities;

namespace ProgrammingLabs.MenuItems;

internal sealed class MenuItemDate : MenuItemCore
{
	internal override string Title => "Date Recursion";

	internal override void Execute ()
	{
		Console.Clear();
		DateTime userDate1 = IOUtils.GetDate("d1st", "Enter First Date Of First Segment: ");
		DateTime userDate2 = IOUtils.GetDate("d1end", "Enter Second Date Of First Segment: ");
		DateTime userDate3 = IOUtils.GetDate("d2st", "Enter First Date Of Second Segment: ");
		DateTime userDate4 = IOUtils.GetDate("d2end", "Enter Second Date Of Second Segment: ");

		Console.Clear();

		Console.WriteLine($"First Date Of First Segment: {userDate1.ToShortDateString()}");
		Console.WriteLine($"Second Date Of First Segment: {userDate2.ToShortDateString()}");
		Console.WriteLine($"First Date Of Second Segment: {userDate3.ToShortDateString()}");
		Console.WriteLine($"Second Date Of Second Segment: {userDate4.ToShortDateString()}");

		int n = IOUtils.GetIntersection(userDate1, userDate2, userDate3, userDate4);
		Console.WriteLine($"{nameof(n)} = {n}");

		if (n <= 0)
		{

			Console.WriteLine($"Calculating prime factors is forbidden if {n} <= {0}");
		}
		else
		{
			PrimeFactorsUtils.CalcFactors(n);
			PrimeFactorsUtils.PrintFactors();
		}

		IOUtils.WaitForKey();

		if (IOUtils.ExternalValues != null)
		{
			_ = Console.ReadLine();
		}
	}
}