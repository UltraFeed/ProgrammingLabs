#pragma warning disable CA1303

using ProgrammingLabs.Utilities;

namespace ProgrammingLabs.MenuItems;

internal sealed class MenuItemCalc : MenuItemCore
{
	internal override string Title => "Calculations";

	internal override void Execute ()
	{
		Console.Clear();
		int x = IOUtils.GetInt(nameof(x), $"Enter {nameof(x)}: ");
		int y = IOUtils.GetInt(nameof(y), $"Enter {nameof(y)}: ");
		int z = IOUtils.GetInt(nameof(z), $"Enter {nameof(z)}: ");
		Console.Clear();

		do
		{
			if (IOUtils.ExternalValues == null)
			{
				Console.WriteLine($"===== MENU =====");
				Console.WriteLine($"0. Exit");
				Console.WriteLine($"01: ( {nameof(x)} + {nameof(y)} ) / {nameof(z)} + Math.Sqrt({nameof(x)})");
				Console.WriteLine($"02: {nameof(x)} / {nameof(z)} + Math.Pow({nameof(y)}, 2)");
				Console.WriteLine($"03: Math.Pow({nameof(z)}, 2) + 7 + Math.Sqrt({nameof(x)})");
				Console.WriteLine($"04: Math.Pow({nameof(y)}, 2) + 3 * Math.Sqrt({nameof(x)}) + {nameof(z)}");
				Console.WriteLine($"05: ( {nameof(y)} - Math.Sqrt({nameof(x)}) ) / {nameof(z)}");
				Console.WriteLine($"06: {nameof(y)} + Math.Sqrt({nameof(x)} % {nameof(z)})");
				Console.WriteLine($"07: {nameof(x)} % {nameof(z)} + Math.Sqrt({nameof(y)})");
				Console.WriteLine($"08: Math.Sqrt({nameof(x)}) - 6 / {nameof(z)}");
				Console.WriteLine($"09: {nameof(z)} / {nameof(x)} + 7 * Math.Sqrt({nameof(y)})");
				Console.WriteLine($"10: ( {nameof(x)} + Math.Sqrt({nameof(y)}) ) / {nameof(z)}");
				Console.WriteLine($"11: ( {nameof(x)} + Math.Sqrt({nameof(y)}) ) % {nameof(z)}");
				Console.WriteLine($"12: {nameof(x)} % {nameof(z)} + Math.Sqrt({nameof(y)})");
				Console.WriteLine($"13: {nameof(x)} * {nameof(y)} % {nameof(z)}");
				Console.WriteLine($"14: ( {nameof(y)} % {nameof(x)} ) / Math.Sqrt({nameof(z)})");
				Console.WriteLine($"15: ( {nameof(y)} - {nameof(x)} ) / Math.Sqrt({nameof(z)})");

				Console.WriteLine($"{nameof(x)} = {x}");
				Console.WriteLine($"{nameof(y)} = {y}");
				Console.WriteLine($"{nameof(z)} = {z}");
			}

			int input = IOUtils.GetInt("cn", $"{nameof(input)} In Range (0-15): ");

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
