using System.Text.Json.Serialization;
using PaypalSdk.Core.Models;

namespace PaypalSdk.Models;

/// <summary>
/// Completes an capture payment for an order.
/// </summary>
public record OrderCaptureRequest
{
    /// <summary>
    /// The payment source definition.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payment_source")]
    public OrderCaptureRequestPaymentSource? PaymentSource { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
