namespace ProgrammingLabs.Utilities;

public static class PrimeFactorsUtils
{
	private static readonly List<int> Factors = [];

	internal static void PrintFactors ()
	{
		Console.WriteLine("All Prime Factors Are: ");

		if (Factors.Count > 0)
		{
			Console.Write(string.Join("*", Factors));
			Console.WriteLine(" ");
		}
		else
		{
			Console.WriteLine("Factors List Is Empty");
		}
	}

	internal static void CalcFactors (int n)
	{
		Factors.Clear();
		Calc(n, 2);
	}

	private static void Calc (int n, int div)
	{
		if (n == 1)
		{
			return;
		}

		if (n % div == 0)
		{
			Factors.Add(div);
			Calc(n / div, div);
		}
		else
		  if (div == 2)
		{
			Calc(n, div + 1);
		}
		else
		{
			Calc(n, div + 2);
		}
	}
}