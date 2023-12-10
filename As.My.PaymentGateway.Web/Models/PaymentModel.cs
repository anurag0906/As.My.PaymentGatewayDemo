namespace As.My.PaymentGateway.Web.Models;

public class PaymentModel
{
	public string PaymentId { get; set; }
	public string PaymentType { get; set; }
	public string Name { get; set; }
	public int Amount { get; set; }=0;

}
