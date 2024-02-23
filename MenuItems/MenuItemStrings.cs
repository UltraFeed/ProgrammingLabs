#pragma warning disable CA1303

using ProgrammingLabs.Utilities;

namespace ProgrammingLabs.MenuItems;

internal sealed class MenuItemStrings : MenuItemCore
{
	internal override string Title => "Strings OPS";

	internal override void Execute ()
	{
		Console.Clear();
		string UserStr1 = IOUtils.GetLine("s1", "Enter First String: ");
		string UserStr2 = IOUtils.GetLine("s2", "Enter Second String: ");
		Console.Clear();
		Console.WriteLine("First String Is:\n" + UserStr1);
		Console.WriteLine("Second String Is:\n" + UserStr2);
		try
		{
			_ = StringsUtils.CheckEquals(UserStr1, UserStr2);
			Console.WriteLine("Strings Are Equal");
		}
		catch (CheckException ex)
		{
			Console.WriteLine(ex.Message);
		}

		IOUtils.WaitForKey();
		Console.WriteLine("Removing Extra Spaces");
		UserStr1 = StringsUtils.RemoveSpaces(UserStr1);
		UserStr2 = StringsUtils.RemoveSpaces(UserStr2);
		Console.WriteLine("First String Is:\n" + UserStr1);
		Console.WriteLine("Second String Is:\n" + UserStr2);

		try
		{
			_ = StringsUtils.CheckEquals(UserStr1, UserStr2);
			Console.WriteLine("Strings Are Equal");
		}
		catch (CheckException ex)
		{
			Console.WriteLine(ex.Message);
		}

		UserStr1 = StringsUtils.ReverseStr(UserStr1);
		IOUtils.WaitForKey();
		Console.WriteLine("Reversing One String");
		Console.WriteLine("First String Is:\n" + UserStr1);
		Console.WriteLine("Second String Is:\n" + UserStr2);

		try
		{
			_ = StringsUtils.CheckEquals(UserStr1, UserStr2);
			Console.WriteLine("Strings Are Equal");
		}
		catch (CheckException ex)
		{
			Console.WriteLine(ex.Message);
		}

		UserStr1 = StringsUtils.ReverseStr(UserStr1);
		IOUtils.WaitForKey();

		try
		{
			StringsUtils.CheckIPv4(UserStr1);
			Console.WriteLine(UserStr1 + " is ipv4 address");
		}
		catch (CheckException ex)
		{
			Console.WriteLine(ex.Message);
		}

		try
		{
			StringsUtils.CheckIPv4(UserStr2);
			Console.WriteLine(UserStr2 + " is ipv4 address");
		}
		catch (CheckException ex)
		{
			Console.WriteLine(ex.Message);
		}

		IOUtils.WaitForKey();

		try
		{
			StringsUtils.CheckPhone(UserStr1);
			Console.WriteLine(UserStr1 + " is phone number");
		}
		catch (CheckException ex)
		{
			Console.WriteLine(ex.Message);
		}

		try
		{
			StringsUtils.CheckPhone(UserStr2);
			Console.WriteLine(UserStr2 + " is phone number");
		}
		catch (CheckException ex)
		{
			Console.WriteLine(ex.Message);
		}

		IOUtils.WaitForKey();

		try
		{
			StringsUtils.CheckEmail(UserStr1);
			Console.WriteLine(UserStr1 + " is email address");

		}
		catch (CheckException ex)
		{
			Console.WriteLine(ex.Message);
		}

		try
		{
			StringsUtils.CheckEmail(UserStr2);
			Console.WriteLine(UserStr2 + " is email address");
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