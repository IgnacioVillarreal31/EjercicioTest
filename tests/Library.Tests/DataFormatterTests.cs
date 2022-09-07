namespace TestDateFormat;

public class DateFormatterTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void FechaFormatoCorrecto()
    {
        var fecha1 = DateFormatter.ChangeFormat("11/12/2012");
        Assert.AreEqual(fecha1,"2012-12-11");
    }

    [Test]
    public void FechaFormatoIncorrecto()
    {
        var fecha1 = DateFormatter.ChangeFormat("20.12.2031");
        Assert.AreEqual(fecha1,"2031-12-20");
    }

    [Test]
    public void FechaBlanco()
    {
        var fecha1 = DateFormatter.ChangeFormat("");
        Assert.AreEqual(fecha1,"");
    }
}