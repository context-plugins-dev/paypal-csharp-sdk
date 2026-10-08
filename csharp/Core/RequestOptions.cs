using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using PaypalSdk.Core.Hooks;

namespace PaypalSdk.Core;

public sealed record RequestOptions
{
    public LogLevel? LogLevel { get; init; }

    public IReadOnlyList<SdkHook>? Hooks { get; init; }
}
