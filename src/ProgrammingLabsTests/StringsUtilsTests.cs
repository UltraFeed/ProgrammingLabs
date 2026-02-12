#pragma warning disable CA1515

using ProgrammingLabs.Utilities;

namespace ProgrammingLabsTests;

[TestClass]
public sealed class StringsUtilsTests
{
	[TestMethod]
	public void CheckEqualsTestTrue ()
	{
		Assert.IsTrue(StringsUtils.CheckEquals("0", "0"));
	}

	[TestMethod]
	public void CheckEqualsTestFalse ()
	{
		_ = Assert.ThrowsExactly<CheckException>(() => StringsUtils.CheckEquals("0", "1"));
	}

	[TestMethod]
	public void CheckIPV4TestFalse ()
	{
		_ = Assert.ThrowsExactly<CheckException>(() => StringsUtils.CheckIPv4("0"));
	}

	[TestMethod]
	public void CheckEmailTestFalse ()
	{
		_ = Assert.ThrowsExactly<CheckException>(() => StringsUtils.CheckEmail("0"));
	}

	[TestMethod]
	public void CheckPhoneTestFalse ()
	{
		_ = Assert.ThrowsExactly<CheckException>(() => StringsUtils.CheckPhone("0"));
	}
}
