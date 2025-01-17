#pragma warning disable CA1515

using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProgrammingLabs.Utilities;

namespace ProgrammingLabsTests;

[TestClass]
public sealed class IOUtilsTests
{
	[TestMethod]
	public void ParseIntTestIntTrue ()
	{
		Assert.IsTrue(IOUtils.ParseInt("1", out _));
	}

	[TestMethod]
	public void ParseIntTestNotIntFalse ()
	{
		Assert.IsFalse(IOUtils.ParseInt("a", out _));
	}

	[TestMethod]
	public void ParseDateTestDateTimeTrue ()
	{
		Assert.IsTrue(IOUtils.ParseDate("11.11.1111", out _));
	}

	[TestMethod]
	public void ParseDateTestNotDateTimeFalse ()
	{
		Assert.IsFalse(IOUtils.ParseDate("a", out _));
	}

	[TestMethod]
	public void GetMinTimeTestFirstDateSmallerD1 ()
	{
		DateTime d1 = DateTime.Today;
		DateTime d2 = d1.AddDays(1);
		Assert.AreEqual(IOUtils.GetMinTime(d1, d2), d1);
	}

	[TestMethod]
	public void GetMinTimeTestFirstDateBiggerD2 ()
	{
		DateTime d1 = DateTime.Today;
		DateTime d2 = d1.AddDays(-1);
		Assert.AreEqual(IOUtils.GetMinTime(d1, d2), d2);
	}

	[TestMethod]
	public void GetMaxTimeTestSecondDateBiggerD2 ()
	{
		DateTime d1 = DateTime.Today;
		DateTime d2 = d1.AddDays(1);
		Assert.AreEqual(IOUtils.GetMaxTime(d1, d2), d2);
	}

	[TestMethod]
	public void GetMaxTimeTestSecondDateSmallerD1 ()
	{
		DateTime d1 = DateTime.Today;
		DateTime d2 = d1.AddDays(-1);
		Assert.AreEqual(IOUtils.GetMaxTime(d1, d2), d1);
	}

	[TestMethod]
	public void GetIntersectionTestExistsNotZero ()
	{
		DateTime a1 = DateTime.Today;
		DateTime b1 = DateTime.Today.AddDays(1);
		DateTime a2 = DateTime.Today;
		DateTime b2 = DateTime.Today.AddDays(2);
		Assert.AreEqual(2, IOUtils.GetIntersection(a1, b1, a2, b2));
	}

	[TestMethod]
	public void GetIntersectionTestDoesNotExistsZero ()
	{
		DateTime a1 = DateTime.Today;
		DateTime b1 = DateTime.Today;
		DateTime a2 = DateTime.Today.AddDays(1);
		DateTime b2 = DateTime.Today.AddDays(1);
		Assert.AreEqual(0, IOUtils.GetIntersection(a1, b1, a2, b2));
	}
}
