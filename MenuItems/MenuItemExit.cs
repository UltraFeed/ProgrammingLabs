using ProgrammingLabs.Utilities;

namespace ProgrammingLabs.MenuItems;

internal sealed class MenuItemExit : MenuItemCore
{
	internal override string Title => "Exit";

	internal override void Execute ()
	{
		Console.Clear();
		IOUtils.WaitForKey();
		Environment.Exit(0);
	}
}
