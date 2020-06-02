using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Rent.Interfaces;
using Rent.Models;

namespace Rent.Controllers
{
    public class RentController : Controller
    {
        public IRentService _rentService;

        public RentController(IRentService rentService)
        {
            _rentService = rentService;
        } 
        // GET: Rent
        public ActionResult Browse_item()
        {
            var products = _rentService.GetAllProducts();
            return View(products);
        }
        public ActionResult DetailProduct(int id)
        {
            var product = _rentService.GetProductById(id);
            return View(product);
        }
           

        public ActionResult RequestToRent(int id)
        {
            decimal money=0;
            if(!_rentService.CheckedReservedProductByProductId(id)) return HttpNotFound();
            //Если нельзя снять то выдаем ошибку, а не 404
            if (!_rentService.WriteOffMoneyFromUserByLogin(money, User.Identity.Name)) return HttpNotFound();

            var TakenProduct = new TakenProduct
            {
                ProductId = id,
                UserId = _rentService.GetUserByLogin(User.Identity.Name).Id,
                Cost = money,
            };
            return Content("Все гуд");
        }

        public ActionResult MyAd()
        {
           var products=_rentService.GetProductByUserId(_rentService.GetUserByLogin(User.Identity.Name).Id);
            return View(products);
        }
        
    }
}