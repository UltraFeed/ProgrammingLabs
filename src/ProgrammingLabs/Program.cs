using ProgrammingLabs.MenuItems;
using ProgrammingLabs.Utilities;

// -mi 0
// -mi 1
// -mi 2 -x 1 -y 2 -z 3 -cn 6
// -mi 3 -d1st 12.12.1212 -d1end 12.12.1212 -d2st 12.12.1212 -d2end 12.12.1212
// -mi 4 -s1 "123" -s2 "321"

namespace ProgrammingLabs;

internal static class Program
{
	private static void Main (string [] args)
	{
		IDictionary<string, string> argsDic = ConsoleParser.Parse(args);
		IOUtils.SetExtValues(argsDic);

		Menu.ClearItems();
		Menu.AddItem(new MenuItemExit());
		Menu.AddItem(new MenuItemHW());
		Menu.AddItem(new MenuItemCalc());
		Menu.AddItem(new MenuItemDate());
		Menu.AddItem(new MenuItemStrings());

		if (argsDic != null)
		{
			Menu.Execute();
			return;
		}
		else
		{
			while (true)
			{
				Menu.ShowMenu();
				Menu.Execute();
			}
		}
	}
}
