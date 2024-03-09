namespace ExtensionMethod;

public class ResponseProcessor
{
    public bool ProcessResponse(Response response)
    {
        if (response.Status != null && response.Status.IsSuccess())
        {
            // Access the status code
            var responseCode = response.Status.Code;

            // Process the response
            return true;
        }

        return false;
    }
}
