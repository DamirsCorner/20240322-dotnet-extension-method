using System.Text.RegularExpressions;

namespace ExtensionMethod;

public partial class ResponseStatus
{
    public string? Code { get; init; }

    public bool IsSuccess() => Code != null && SuccessCodeRegex().IsMatch(Code);

    [GeneratedRegex(@"^2\d{2}$")]
    private static partial Regex SuccessCodeRegex();
}
