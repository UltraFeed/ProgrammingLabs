#pragma warning disable SYSLIB1045

using System.Text.RegularExpressions;

namespace ProgrammingLabs.Utilities;

public static class StringsUtils
{
	public static bool CheckEquals (string UserStr1, string UserStr2)
	{
		if (UserStr1.Equals(UserStr2, StringComparison.Ordinal))
		{
			return true;
		}
		else
		{
			throw new CheckException("Strings Are Not Equal");
		}
	}

	public static string ReverseStr (string userString)
	{
		return new string(userString.ToCharArray().Reverse().ToArray());
	}

	public static string RemoveSpaces (string userStr)
	{
		return Regex.Replace(userStr.ToLowerInvariant(), @"\s+", " ").Trim();
	}

	public static void CheckIPv4 (string UserStr)
	{
		Regex IPV4 = new(@"(\b25[0-5]|\b2[0-4][0-9]|\b[01]?[0-9][0-9]?)(\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)){3}");
		MatchCollection IPV4Matches = IPV4.Matches(UserStr);

		if (IPV4Matches.Count > 0)
		{
			return;
		}
		else
		{
			throw new CheckException($"{UserStr} Is Not IP V4 Address");
		}
	}
	public static void CheckEmail (string UserStr)
	{
		Regex Email = new(@"(([^<>()\[\]\\.,;:\s@""]+(\.[^<>()\[\]\\.,;:\s@""]+)*)|("".+""))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))");
		MatchCollection EmailMatches = Email.Matches(UserStr);

		if (EmailMatches.Count > 0)
		{
			return;
		}
		else
		{
			throw new CheckException($"{UserStr} Is Not An Email Adress");
		}
	}

	public static void CheckPhone (string UserStr)
	{
		Regex Phone = new(@"^[\+]?[(]?[0-9]{3}[)]?[-\s\.]?[0-9]{3}[-\s\.]?[0-9]{4,6}$");
		MatchCollection PhoneMatches = Phone.Matches(UserStr);

		if (PhoneMatches.Count > 0)
		{
			return;
		}
		else
		{
			throw new CheckException($"{UserStr} Is Not A Phone Number");
		}
	}
}
public class CheckException (string message) : Exception(message)
{
}