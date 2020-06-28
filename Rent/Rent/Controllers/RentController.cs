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
        
        public ActionResult CreateProduct()
        {
            SelectList category = new SelectList(_rentService.GetAllGategories(), "Id", "Name");
            ViewBag.Category = category;
            var product = new Product();
            return View(product);
        }
        [HttpPost]
        public ActionResult CreateProduct(Product product)
        {
           
            return View();
        }
        public ActionResult RequestToRent(int id)
        {
            decimal money=0;
            if(!_rentService.CheckedIsTakenProductByProductId(id)) return HttpNotFound();
            //Если нельзя снять то выдаем ошибку, а не 404
            if (!_rentService.WriteOffMoneyFromUserByLogin(money, User.Identity.Name)) return HttpNotFound();

            var takenProduct = new TakenProduct
            {
                ProductId = id,
                UserId = _rentService.GetUserByLogin(User.Identity.Name).Id,
                Cost = money,
            };
            _rentService.CreateTakenProduct(takenProduct);
            return Content("Все гуд");
        }

        public ActionResult MyAd()
        {
           var products=_rentService.GetProductByUserId(_rentService.GetUserByLogin(User.Identity.Name).Id);
            return View(products);
        }
        public ActionResult RequestedAd()
        {
            var takenProducts =
                _rentService.GetAllTakenProductsByUserId(_rentService.GetUserByLogin(User.Identity.Name).Id);
            return View(takenProducts);
        }
        public ActionResult ChekedLessorProof(int idTakenProduct)
        {
            var userId = _rentService.GetUserByLogin(User.Identity.Name).Id;
            _rentService.ChekedLessorProof(idTakenProduct, userId);
            return RedirectToAction("RequestedAd");
        }
        public ActionResult ChekedLessorReturnProof(int idTakenProduct)
        {
            var userId = _rentService.GetUserByLogin(User.Identity.Name).Id;
            //помечаем что арендодатель подтвердил возврат товара
            _rentService.ChekedLessorReturnProof(idTakenProduct, userId);
            _rentService.DeleteTakenProductById(idTakenProduct,userId);
            return RedirectToAction("RequestedAd");
        }
        public ActionResult ListMyTakenProduct()
        {
            var userId = _rentService.GetUserByLogin(User.Identity.Name).Id;
            var TakenProducts = _rentService.GetAllListMyTakenProduct(userId);
            return View(TakenProducts);
        }
        public ActionResult CheckedTenantProof(int idTakenProduct)
        {
            var userId = _rentService.GetUserByLogin(User.Identity.Name).Id;
            _rentService.CheckedTenantProof(idTakenProduct, userId);
            return RedirectToAction("ListMyTakenProduct");
        }
    }
}