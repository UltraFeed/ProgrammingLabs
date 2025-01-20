#pragma warning disable CA1303

using ProgrammingLabs.Utilities;

namespace ProgrammingLabs.MenuItems;

internal sealed class MenuItemHW : MenuItemCore
{
	internal override string Title => "Hello World";

	internal override void Execute ()
	{
		Console.Clear();
		Console.WriteLine("Hello World!");
		IOUtils.WaitForKey();
		if (IOUtils.ExternalValues != null)
		{
			_ = Console.ReadLine();
		}
	}
}
