namespace GithubActionsLab;

[TestClass]
public class Addition
{
	[TestMethod]
	public void Add_Valid_Patino()
	{
		Assert.AreEqual(3, Program.Add("1", "2"));
		Assert.AreEqual(5, Program.Add("3", "2"));
		Assert.AreEqual(12, Program.Add("5", "7"));
	}

	[TestMethod]
	public void Add_Invalid_Patino()
	{
		Assert.ThrowsException<FormatException>(() => Program.Add("1", "a"));
		Assert.ThrowsException<FormatException>(() => Program.Add("a", "1"));
		Assert.ThrowsException<FormatException>(() => Program.Add("a", "a"));
	}

	[TestMethod]
	public void Add_Null_Patino()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add("1", null));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, "1"));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, null));
	}
}


[TestClass]
public class Subtraction
{
	[TestMethod]
	public void Subtract_Valid_McGrury()
	{
		Assert.AreEqual(1, Program.Subtract("3", "2"));
		Assert.AreEqual(2, Program.Subtract("5", "3"));
		Assert.AreEqual(0, Program.Subtract("7", "7"));
    }

	[TestMethod]
	public void Subtract_Invalid_McGrury()
	{
		Assert.ThrowsException<FormatException>(() => Program.Subtract("1", "b"));
		Assert.ThrowsException<FormatException>(() => Program.Subtract("b", "1"));
		Assert.ThrowsException<FormatException>(() => Program.Subtract("b", "b"));
    }

	[TestMethod]
	public void Subtract_Null_McGrury()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract("1", null));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract(null, "1"));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract(null, null));
    }
}

[TestClass]
public class Multiplication
{
    [TestMethod]
    public void Multiply_Valid_McGrury()
    {
        Assert.AreEqual(6, Program.Multiply("3", "2"));
        Assert.AreEqual(-10, Program.Multiply("-5", "2"));
        Assert.AreEqual(3.75, Program.Multiply("1.5", "2.5"));
    }

    [TestMethod]
    public void Multiply_Invalid_McGrury()
    {
        Assert.ThrowsException<FormatException>(() => Program.Multiply("a", "2"));
        Assert.ThrowsException<FormatException>(() => Program.Multiply("3", "b"));
        Assert.ThrowsException<FormatException>(() => Program.Multiply("a", "b"));
    }

    [TestMethod]
    public void Multiply_Null_McGrury()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply("1", null));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply(null, "1"));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply(null, null));
    }
}

[TestClass]
public class Division
{
    [TestMethod]
    public void Divide_Valid_McGrury()
    {
        Assert.AreEqual(2, Program.Divide("4", "2"));
        Assert.AreEqual(-3, Program.Divide("-9", "3"));
        Assert.AreEqual(3, Program.Divide("7.5", "2.5"));
    }

    [TestMethod]
    public void Divide_ByZero_McGrury()
    {
        var posInf = Program.Divide("1", "0");
        Assert.IsTrue(double.IsPositiveInfinity(posInf));

        var negInf = Program.Divide("-1", "0");
        Assert.IsTrue(double.IsNegativeInfinity(negInf));

        var nan = Program.Divide("0", "0");
        Assert.IsTrue(double.IsNaN(nan));
    }

    [TestMethod]
    public void Divide_Invalid_McGrury()
    {
        Assert.ThrowsException<FormatException>(() => Program.Divide("x", "2"));
        Assert.ThrowsException<FormatException>(() => Program.Divide("3", "y"));
        Assert.ThrowsException<FormatException>(() => Program.Divide("x", "y"));
    }

    [TestMethod]
    public void Divide_Null_McGrury()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Divide("1", null));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Divide(null, "1"));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Divide(null, null));
    }
}

[TestClass]
public class Power
{
    [TestMethod]
    public void Power_Valid_McGrury()
    {
        Assert.AreEqual(8, Program.Power("2", "3"));
        Assert.AreEqual(1, Program.Power("5", "0"));
        Assert.AreEqual(0.25, Program.Power("2", "-2"));
        Assert.AreEqual(3, Program.Power("9", "0.5"));
    }

    [TestMethod]
    public void Power_Invalid_McGrury()
    {
        Assert.ThrowsException<FormatException>(() => Program.Power("x", "2"));
        Assert.ThrowsException<FormatException>(() => Program.Power("2", "y"));
        Assert.ThrowsException<FormatException>(() => Program.Power("x", "y"));
    }

    [TestMethod]
    public void Power_Null_McGrury()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Power("1", null));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Power(null, "1"));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Power(null, null));
    }
}