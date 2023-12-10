using As.My.PaymentGateway.Web.Models;
using As.My.PaymentGateway.Web.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace As.My.PaymentGateway.Web.Controllers;

public class MyCheckoutController : Controller
{
	private readonly IBraintreeService _braintreeService;

	public MyCheckoutController(IBraintreeService braintreeService)
	{
		_braintreeService = braintreeService;
	}
	// GET: MyCheckoutController
	public ActionResult Index()
	{
		var model = new PaymentModel() { Amount=1};
		var gateway = _braintreeService.GetGateway();
		var clientToken = gateway.ClientToken.Generate();
		ViewBag.ClientToken = clientToken;

		ViewBag.Amount = model.Amount;
		return View(model);
	}

	public ActionResult Purchase(PaymentModel model)
	{

		
		return View();
	}

	//// GET: MyCheckoutController/Details/5
	//public ActionResult Details(int id)
	//{
	//	return View();
	//}

	//// GET: MyCheckoutController/Create
	//public ActionResult Create()
	//{
	//	return View();
	//}

	//// POST: MyCheckoutController/Create
	//[HttpPost]
	//[ValidateAntiForgeryToken]
	//public ActionResult Create(IFormCollection collection)
	//{
	//	try
	//	{
	//		return RedirectToAction(nameof(Index));
	//	}
	//	catch
	//	{
	//		return View();
	//	}
	//}

	//// GET: MyCheckoutController/Edit/5
	//public ActionResult Edit(int id)
	//{
	//	return View();
	//}

	//// POST: MyCheckoutController/Edit/5
	//[HttpPost]
	//[ValidateAntiForgeryToken]
	//public ActionResult Edit(int id, IFormCollection collection)
	//{
	//	try
	//	{
	//		return RedirectToAction(nameof(Index));
	//	}
	//	catch
	//	{
	//		return View();
	//	}
	//}

	//// GET: MyCheckoutController/Delete/5
	//public ActionResult Delete(int id)
	//{
	//	return View();
	//}

	//// POST: MyCheckoutController/Delete/5
	//[HttpPost]
	//[ValidateAntiForgeryToken]
	//public ActionResult Delete(int id, IFormCollection collection)
	//{
	//	try
	//	{
	//		return RedirectToAction(nameof(Index));
	//	}
	//	catch
	//	{
	//		return View();
	//	}
	//}
}
