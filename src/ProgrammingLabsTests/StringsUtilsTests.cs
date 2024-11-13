#pragma warning disable CA1812

using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProgrammingLabs.Utilities;

namespace ProgrammingLabsTests;

[TestClass]
internal sealed class StringsUtilsTests
{
	[TestMethod]
	public void CheckEqualsTestTrue ()
	{
		Assert.IsTrue(StringsUtils.CheckEquals("0", "0"));
	}

	[TestMethod]
	public void CheckEqualsTestFalse ()
	{
		_ = Assert.ThrowsException<CheckException>(() => StringsUtils.CheckEquals("0", "1"));
	}

	[TestMethod]
	public void CheckIPV4TestFalse ()
	{
		_ = Assert.ThrowsException<CheckException>(() => StringsUtils.CheckIPv4("0"));
	}

	[TestMethod]
	public void CheckEmailTestFalse ()
	{
		_ = Assert.ThrowsException<CheckException>(() => StringsUtils.CheckEmail("0"));
	}

	[TestMethod]
	public void CheckPhoneTestFalse ()
	{
		_ = Assert.ThrowsException<CheckException>(() => StringsUtils.CheckPhone("0"));
	}
}
