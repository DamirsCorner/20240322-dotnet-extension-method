namespace ExtensionMethod;

public class ResponseProcessorTests
{
    [Test]
    [TestCase("200")]
    [TestCase("204")]
    public void WillProcessForSuccessStatusCode(string code)
    {
        var response = new Response { Status = new ResponseStatus { Code = code } };
        var processor = new ResponseProcessor();

        Assert.That(processor.ProcessResponse(response), Is.True);
    }

    [Test]
    [TestCase("400")]
    [TestCase("500")]
    public void WillNotProcessForFailStatusCode(string code)
    {
        var response = new Response { Status = new ResponseStatus { Code = code } };
        var processor = new ResponseProcessor();

        Assert.That(processor.ProcessResponse(response), Is.False);
    }

    [Test]
    public void WillNotProcessForNullStatusCode()
    {
        var response = new Response { Status = new ResponseStatus() };
        var processor = new ResponseProcessor();

        Assert.That(processor.ProcessResponse(response), Is.False);
    }

    [Test]
    public void WillThrowForNullStatus()
    {
        var response = new Response();
        var processor = new ResponseProcessor();

        Assert.That(
            () => processor.ProcessResponse(response),
            Throws.TypeOf<NullReferenceException>()
        );
    }
}
