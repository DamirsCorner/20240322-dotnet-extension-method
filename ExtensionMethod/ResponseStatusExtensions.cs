using System.Text.RegularExpressions;

namespace ExtensionMethod;

public static partial class ResponseStatusExtensions
{
    public static bool IsSuccess(this ResponseStatus? status) =>
        status?.Code != null && SuccessCodeRegex().IsMatch(status.Code);

    [GeneratedRegex(@"^2\d{2}$")]
    private static partial Regex SuccessCodeRegex();
}
