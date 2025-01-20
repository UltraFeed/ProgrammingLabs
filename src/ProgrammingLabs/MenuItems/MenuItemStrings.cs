#pragma warning disable CA1303

using ProgrammingLabs.Utilities;

namespace ProgrammingLabs.MenuItems;

internal sealed class MenuItemStrings : MenuItemCore
{
	internal override string Title => "Strings OPS";

	internal override void Execute ()
	{
		Console.Clear();
		string userStr1 = IOUtils.GetLine("s1", "Enter First String: ");
		string userStr2 = IOUtils.GetLine("s2", "Enter Second String: ");
		Console.Clear();
		Console.WriteLine($"First String Is:\n{userStr1}");
		Console.WriteLine($"Second String Is:\n{userStr2}");
		try
		{
			_ = StringsUtils.CheckEquals(userStr1, userStr2);
			Console.WriteLine("Strings Are Equal");
		}
		catch (CheckException ex)
		{
			Console.WriteLine(ex.Message);
		}

		IOUtils.WaitForKey();
		Console.WriteLine("Removing Extra Spaces");
		userStr1 = StringsUtils.RemoveSpaces(userStr1);
		userStr2 = StringsUtils.RemoveSpaces(userStr2);
		Console.WriteLine($"First String Is:\n{userStr1}");
		Console.WriteLine($"Second String Is:\n{userStr2}");

		try
		{
			_ = StringsUtils.CheckEquals(userStr1, userStr2);
			Console.WriteLine("Strings Are Equal");
		}
		catch (CheckException ex)
		{
			Console.WriteLine(ex.Message);
		}

		userStr1 = StringsUtils.ReverseStr(userStr1);
		IOUtils.WaitForKey();
		Console.WriteLine("Reversing One String");
		Console.WriteLine($"First String Is:\n{userStr1}");
		Console.WriteLine($"Second String Is:\n{userStr2}");

		try
		{
			_ = StringsUtils.CheckEquals(userStr1, userStr2);
			Console.WriteLine("Strings Are Equal");
		}
		catch (CheckException ex)
		{
			Console.WriteLine(ex.Message);
		}

		userStr1 = StringsUtils.ReverseStr(userStr1);
		IOUtils.WaitForKey();

		try
		{
			StringsUtils.CheckIPv4(userStr1);
			Console.WriteLine($"{userStr1} is ipv4 address");
		}
		catch (CheckException ex)
		{
			Console.WriteLine(ex.Message);
		}

		try
		{
			StringsUtils.CheckIPv4(userStr2);
			Console.WriteLine($"{userStr2} is ipv4 address");
		}
		catch (CheckException ex)
		{
			Console.WriteLine(ex.Message);
		}

		IOUtils.WaitForKey();

		try
		{
			StringsUtils.CheckPhone(userStr1);
			Console.WriteLine($"{userStr1} is phone number");
		}
		catch (CheckException ex)
		{
			Console.WriteLine(ex.Message);
		}

		try
		{
			StringsUtils.CheckPhone(userStr2);
			Console.WriteLine($"{userStr2} is phone number");
		}
		catch (CheckException ex)
		{
			Console.WriteLine(ex.Message);
		}

		IOUtils.WaitForKey();

		try
		{
			StringsUtils.CheckEmail(userStr1);
			Console.WriteLine($"{userStr1} is email address");
		}
		catch (CheckException ex)
		{
			Console.WriteLine(ex.Message);
		}

		try
		{
			StringsUtils.CheckEmail(userStr2);
			Console.WriteLine($"{userStr2} is email address");
		}
		catch (CheckException ex)
		{
			Console.WriteLine(ex.Message);
		}

		IOUtils.WaitForKey();

		if (IOUtils.ExternalValues != null)
		{
			_ = Console.ReadLine();
		}
	}
}
