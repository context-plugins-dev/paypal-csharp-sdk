using System.Text.Json.Serialization;
using PaypalSdk.Core.Models;
using PaypalSdk.Core.Validation.Attributes;

namespace PaypalSdk.Models;

/// <summary>
/// The update pricing scheme request details.
/// </summary>
public record UpdatePricingScheme
{
    /// <summary>
    /// The billing cycle sequence.
    /// </summary>
    [JsonPropertyName("billing_cycle_sequence")]
    [Minimum(1)]
    [Maximum(99)]
    public required int BillingCycleSequence { get; init; }

    /// <summary>
    /// The pricing scheme details.
    /// </summary>
    [JsonPropertyName("pricing_scheme")]
    public required SubscriptionPricingScheme PricingScheme { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
