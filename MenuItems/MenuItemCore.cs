namespace ProgrammingLabs.MenuItems;

internal abstract class MenuItemCore
{
	internal abstract string Title
	{
		get;
	}

	internal abstract void Execute ();
}