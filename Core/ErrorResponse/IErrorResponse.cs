using System.Threading;
using System.Threading.Tasks;
using PaypalSdk.Core.Models;

namespace PaypalSdk.Core.ErrorResponse;

internal interface IErrorResponse<TError>
{
    Task<TError> Map(ResponseContext context, CancellationToken cancellationToken);
}