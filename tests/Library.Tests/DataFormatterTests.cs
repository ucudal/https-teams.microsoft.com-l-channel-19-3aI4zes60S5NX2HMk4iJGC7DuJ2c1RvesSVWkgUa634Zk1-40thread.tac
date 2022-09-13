 using TestDateFormat;
namespace Library.Tests;

[TestFixture]
public class DateFormatterTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void fechacorrecta()
    {
        string expected = "2001-04-18";
        string fecha = "18/04/2001";
        Assert.AreEqual(expected, DateFormatter.ChangeFormat(fecha));

    }

    [Test]
    public void fechamal()
    {

       string expected = "ERROR. Ingrese una fecha correcta.";
       string fecha = "123";
       Assert.AreEqual(expected, DateFormatter.ChangeFormat(fecha));

    }

    [Test]
    public void fechablanca()
    {
        string expected = "ERROR. Ingrese una fecha correcta.";
        string fecha = "";
        Assert.AreEqual(expected, DateFormatter.ChangeFormat(fecha));
    
    }

}
