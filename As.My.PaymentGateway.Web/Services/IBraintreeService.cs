using Braintree;

namespace As.My.PaymentGateway.Web.Services;

public interface IBraintreeService
{
    IBraintreeGateway CreateGateway();
    IBraintreeGateway GetGateway();
}
