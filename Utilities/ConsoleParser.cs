#pragma warning disable CS8603

namespace ProgrammingLabs.Utilities;

internal static class ConsoleParser
{
	internal static IDictionary<string, string> Parse (string [] args)
	{
		if (args == null || args.Length == 0)
		{
			return null;
		}

		Dictionary<string, string> dic = [];

		for (int i = 0; i < args.Length - 1; i++)
		{
			if (args [i] [0] == '-' && i + 1 < args.Length)
			{
				string paramName = args [i] [1..];
				if (!dic.ContainsKey(paramName))
				{
					dic [paramName] = args [i + 1];
				}
				else
				{
					throw new InvalidOperationException($"Incorrect args. {paramName} must specify once.");
				}
			}
		}

		return dic;
	}
}