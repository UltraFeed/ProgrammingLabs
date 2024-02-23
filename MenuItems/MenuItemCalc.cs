#pragma warning disable CA1303

using ProgrammingLabs.Utilities;

namespace ProgrammingLabs.MenuItems;

internal sealed class MenuItemCalc : MenuItemCore
{
	internal override string Title => "Calculations";

	internal override void Execute ()
	{
		Console.Clear();
		int x = IOUtils.GetInt("x", "Enter x: ");
		int y = IOUtils.GetInt("y", "Enter y: ");
		int z = IOUtils.GetInt("z", "Enter z: ");
		Console.Clear();

		do
		{
			if (IOUtils.ExternalValues == null)
			{
				Console.WriteLine("===== MENU =====");
				Console.WriteLine("0. Exit");
				Console.WriteLine("01: ( x + y ) / z + sqrt(x)");
				Console.WriteLine("02: x / z + y^2");
				Console.WriteLine("03: z^2 + 7 + sqrt(x)");
				Console.WriteLine("04: y^2 + 3 * sqrt(x) + z");
				Console.WriteLine("05: ( y - sqrt(x) ) / z");
				Console.WriteLine("06: y + sqrt(x % z)");
				Console.WriteLine("07: x % z + sqrt(y)");
				Console.WriteLine("08: sqrt(x) - 6 / z");
				Console.WriteLine("09: z / x + 7 * sqrt(y)");
				Console.WriteLine("10: ( x + sqrt(y) ) / z");
				Console.WriteLine("11: ( x + sqrt(y) ) % z");
				Console.WriteLine("12: x % z + sqrt(y)");
				Console.WriteLine("13: x * y % z");
				Console.WriteLine("14: ( y % x ) / sqrt(z)");
				Console.WriteLine("15: ( y - x ) / sqrt(z)");

				Console.WriteLine("x = " + x);
				Console.WriteLine("y = " + y);
				Console.WriteLine("z = " + z);
			}
			int input = IOUtils.GetInt("cn", "Input In Range (0-15): ");

			if (input == 1)
			{
				if (x < 0 | z == 0)
				{
					Console.WriteLine("Forbidden Operation");
				}
				else
				{
					Console.WriteLine($"{((x + y) / z) + Math.Sqrt(x):N3}");
				}
			}

			else if (input == 2)
			{
				if (z == 0)
				{
					Console.WriteLine("Forbidden Operation");
				}
				else
				{
					Console.WriteLine($"{(x / z) + Math.Pow(y, 2):N3}");
				}
			}

			else if (input == 3)
			{
				if (x < 0)
				{
					Console.WriteLine("Forbidden Operation");
				}
				else
				{
					Console.WriteLine(value: $"{Math.Pow(z, 2) + 7 + Math.Sqrt(x):N3}");
				}
			}

			else if (input == 4)
			{
				if (x < 0)
				{
					Console.WriteLine("Forbidden Operation");
				}
				else
				{
					Console.WriteLine($"{Math.Pow(y, 2) + (3 * Math.Sqrt(x)) + z:N3}");
				}
			}

			else if (input == 5)
			{
				if (x < 0 | z == 0)
				{
					Console.WriteLine("Forbidden Operation");
				}
				else
				{
					Console.WriteLine(value: $"{(y - Math.Sqrt(x)) / z:N3}");
				}
			}

			else if (input == 6)
			{
				if (z == 0)
				{
					Console.WriteLine("Forbidden Operation");
				}
				else
				{
					Console.WriteLine(value: $"{y + Math.Sqrt(x % z):N3}");
				}
			}

			else if (input == 7)
			{
				if (y < 0 | z == 0)
				{
					Console.WriteLine("Forbidden Operation");
				}
				else
				{
					Console.WriteLine($"{(x % z) + Math.Sqrt(y):N3}");
				}
			}

			else if (input == 8)
			{
				if (x < 0 | z == 0)
				{
					Console.WriteLine("Forbidden Operation");
				}
				else
				{
					Console.WriteLine($"{Math.Sqrt(x) - (6 / z):N3}");
				}
			}

			else if (input == 9)
			{
				if (y < 0 | x == 0)
				{
					Console.WriteLine("Forbidden Operation");
				}
				else
				{
					Console.WriteLine($"{(z / x) + (7 * Math.Sqrt(y)):N3}");
				}
			}

			else if (input == 10)
			{
				if (y < 0 | z == 0)
				{
					Console.WriteLine("Forbidden Operation");
				}
				else
				{
					Console.WriteLine(value: $"{(x + Math.Sqrt(y)) / z:N3}");
				}
			}

			else if (input == 11)
			{
				if (y < 0 | z == 0)
				{
					Console.WriteLine("Forbidden Operation");
				}
				else
				{
					Console.WriteLine(value: $"{(x + Math.Sqrt(y)) % z:N3}");
				}
			}

			else if (input == 12)
			{
				if (y < 0 | z == 0)
				{
					Console.WriteLine("Forbidden Operation");
				}
				else
				{
					Console.WriteLine($"{(x % z) + Math.Sqrt(y):N3}");
				}
			}

			else if (input == 13)
			{
				if (z == 0)
				{
					Console.WriteLine("Forbidden Operation");
				}
				else
				{
					Console.WriteLine(value: $"{x * y % z:N3}");
				}
			}

			else if (input == 14)
			{
				if (x == 0 | z <= 0)
				{
					Console.WriteLine("Forbidden Operation");
				}
				else
				{
					Console.WriteLine($"{y % x / Math.Sqrt(z):N3}");
				}
			}

			else if (input == 15)
			{
				if (z <= 0)
				{
					Console.WriteLine("Forbidden Operation");
				}
				else
				{
					Console.WriteLine(value: $"{(y - x) / Math.Sqrt(z):N3}");
				}
			}

			else if (input == 0)
			{
				IOUtils.WaitForKey();
				break;
			}
			else
			{
				Console.WriteLine("Unknown Input");
			}
			IOUtils.WaitForKey();
			if (IOUtils.ExternalValues != null)
			{
				_ = Console.ReadLine();
			}
		} while (true && IOUtils.ExternalValues == null);
	}
}