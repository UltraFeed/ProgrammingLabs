#pragma warning disable CA1303

using ProgrammingLabs.MenuItems;
using ProgrammingLabs.Utilities;

namespace ProgrammingLabs;

internal static class Menu
{
	private static readonly List<MenuItemCore> MenuItems = [];
	internal static void ClearItems ()
	{
		MenuItems.Clear();
	}

	internal static void AddItem (MenuItemCore menuItem)
	{
		MenuItems.Add(menuItem);
	}

	internal static void Execute ()
	{
		int iMenu = IOUtils.GetInt("mi", "");
		if (iMenu >= 0 && iMenu < MenuItems.Count)
		{
			MenuItems.ToArray() [iMenu].Execute();
		}
		else
		{
			Console.WriteLine("Unknown Index");
			IOUtils.WaitForKey();
		}
	}
	internal static void ShowMenu ()
	{
		Console.WriteLine("===== MENU =====");
		int iMenuItem = 0;
		foreach (MenuItemCore menuItem in MenuItems)
		{
			Console.WriteLine($"{iMenuItem++}: {menuItem.Title}");
		}
	}
}
