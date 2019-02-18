using ProductFirstVersion.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace ProductFirstVersion.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        //to get list of customers
        public ActionResult Customer()
        {
            using (ProductFirstVersionEntities dbobj = new ProductFirstVersionEntities())
            {
                var customer = dbobj.Customers.ToList();

                return View(customer);
            }
        }
         // add customer
        public ActionResult CreateCustomer()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateCustomer(Customer newcustomer)
        {
            if (ModelState.IsValid)
            {
                using (ProductFirstVersionEntities dbobj = new ProductFirstVersionEntities())
                {
                    dbobj.Customers.Add(newcustomer);
                    dbobj.SaveChanges();

                    return RedirectToAction("Customer");
                }
            }
            return View();
        }
        // get by id
        public ActionResult CustomerDetails(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            using (ProductFirstVersionEntities dbobj = new ProductFirstVersionEntities())
            {
                var customer = dbobj.Customers.Where(x => x.CustomerId == id).FirstOrDefault();
                if(customer == null)
                {
                    return HttpNotFound();
                }
                return View(customer);
            }
        }
        // update
        public ActionResult EditCustomer(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            using (ProductFirstVersionEntities dbobj = new ProductFirstVersionEntities())
            {
                var customer = dbobj.Customers.Where(x => x.CustomerId == id).FirstOrDefault();
                if (customer == null)
                {
                    return HttpNotFound();
                }

                return View(customer);
            }
        }
        [HttpPost]
        public ActionResult EditCustomer(int id, Customer newcustomer)
        {
            if (ModelState.IsValid)
            {
                using (ProductFirstVersionEntities dbobj = new ProductFirstVersionEntities())
                {
                    dbobj.Entry(newcustomer).State = EntityState.Modified;
                    dbobj.SaveChanges();

                    return RedirectToAction("Customer");
                }
            }
            return View();
        }
        // delete 
        public ActionResult DeleteCustomer(int id)
        {
            using (ProductFirstVersionEntities dbobj = new ProductFirstVersionEntities())
            {
                var customer = dbobj.Customers.Where(x => x.CustomerId == id).FirstOrDefault();
                return View(customer);
            }
        }
        [HttpPost]
        public ActionResult DeleteCustomer(int id, Customer newcustomer)
        {
            using (ProductFirstVersionEntities dbobj = new ProductFirstVersionEntities())
            {
                var customer = dbobj.Customers.Where(x => x.CustomerId == id).FirstOrDefault();
                dbobj.Customers.Remove(customer);

                dbobj.SaveChanges();

                return RedirectToAction("Customer");
            }
        }
        // get list of all products
        public ActionResult Product()
        {
            using (ProductFirstVersionEntities dbobj = new ProductFirstVersionEntities())
            {
                var product = dbobj.Products.ToList();

                return View(product);
            }
        }
        // add new product
        public ActionResult CreateProduct()
        {
            return View();
        }
        [HttpPost]

        public ActionResult CreateProduct(Product newproduct)
        {

            if (ModelState.IsValid)
            {
                using (ProductFirstVersionEntities dbobj = new ProductFirstVersionEntities())
                {
                    dbobj.Products.Add(newproduct);
                    dbobj.SaveChanges();

                    return RedirectToAction("Product");
                }
            }
            return View();
        }
        // get product by id
        public ActionResult ProductDetails(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            using (ProductFirstVersionEntities dbobj = new ProductFirstVersionEntities())
            {
                var product = dbobj.Products.Where(x => x.ProductId == id).FirstOrDefault();
                if (product == null)
                {
                    return HttpNotFound();
                }
                return View(product);
            }
        }
        // update
        public ActionResult EditProduct(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            using (ProductFirstVersionEntities dbobj = new ProductFirstVersionEntities())
            {
                var product = dbobj.Products.Where(x => x.ProductId == id).FirstOrDefault();
                if (product == null)
                {
                    return HttpNotFound();
                }
                return View(product);
            }
        }
        [HttpPost]
        public ActionResult EditProduct(int id, Product newproduct)
        {
            if (ModelState.IsValid)
            {
                using (ProductFirstVersionEntities dbobj = new ProductFirstVersionEntities())
                {
                    dbobj.Entry(newproduct).State = EntityState.Modified;
                    dbobj.SaveChanges();

                    return RedirectToAction("Product");
                }
            }
            return View();
        }
        // delete record
        public ActionResult DeleteProduct(int id)
        {
            using (ProductFirstVersionEntities dbobj = new ProductFirstVersionEntities())
            {
                var product = dbobj.Products.Where(x => x.ProductId == id).FirstOrDefault();
                return View(product);
            }
        }
        [HttpPost]
        public ActionResult DeleteProduct(int id, Product newproduct)
        {
            using (ProductFirstVersionEntities dbobj = new ProductFirstVersionEntities())
            {
                var product = dbobj.Products.Where(x => x.ProductId == id).FirstOrDefault();
                dbobj.Products.Remove(product);

                dbobj.SaveChanges();
                return RedirectToAction("Product");
            }
        }
        // list of stores
        public ActionResult Store()
        {
            using (ProductFirstVersionEntities dbobj = new ProductFirstVersionEntities())
            {
                var store = dbobj.Stores.ToList();
                return View(store);
            }
        }
        // add store
        public ActionResult CreateStore()
        {
            return View();
        }
        [HttpPost]

        public ActionResult CreateStore(Store newstore)
        {
            if (ModelState.IsValid)
            {
                using (ProductFirstVersionEntities dbobj = new ProductFirstVersionEntities())
                {
                    dbobj.Stores.Add(newstore);
                    dbobj.SaveChanges();
                    return RedirectToAction("Store");
                }
            }
            return View();
        }
        // get by id
        public ActionResult StoreDetails(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            using (ProductFirstVersionEntities dbobj = new ProductFirstVersionEntities())
            {
                var store = dbobj.Stores.Where(x => x.StoreId == id).FirstOrDefault();
                if (store == null)
                {
                    return HttpNotFound();
                }
                return View(store);
            }
        }
        // update store records
        public ActionResult EditStore(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            using (ProductFirstVersionEntities dbobj = new ProductFirstVersionEntities())
            {
                var store = dbobj.Stores.Where(x => x.StoreId == id).FirstOrDefault();
                if (store == null)
                {
                    return HttpNotFound();
                }
                return View(store);
            }
        }
        [HttpPost]
        public ActionResult EditStore(int id, Store newstore)
        {
            if (ModelState.IsValid)
            {
                using (ProductFirstVersionEntities dbobj = new ProductFirstVersionEntities())
                {
                    dbobj.Entry(newstore).State = EntityState.Modified;
                    dbobj.SaveChanges();

                    return RedirectToAction("Store");
                }
            }
            return View();
        }
        // delete store
        public ActionResult DeleteStore(int id)
        {
            using (ProductFirstVersionEntities dbobj = new ProductFirstVersionEntities())
            {
                var s = dbobj.Stores.Where(x => x.StoreId == id).FirstOrDefault();
                return View(s);
            }
        }
        [HttpPost]
        public ActionResult DeleteStore(int id, Store s)
        {
            using (ProductFirstVersionEntities dbobj = new ProductFirstVersionEntities())
            {
                var store = dbobj.Stores.Where(x => x.StoreId == id).FirstOrDefault();
                dbobj.Stores.Remove(store);
                dbobj.SaveChanges();
                return RedirectToAction("Store");
            }
        }

        public ActionResult ProductSold()
        {
            ProductFirstVersionEntities dbobj = new ProductFirstVersionEntities();
                         var productsold = dbobj.ProductSolds
                         .Select(s => new customerproductnameview
                         {
                             ProductSoldId = s.ProductSoldId,
                             CustomerName = s.CustomerName,
                             ProductName = s.ProductName,

                         });
                return View(productsold);
            
        }
        public ActionResult CreateProductSold()
        {
            return View();
        }
        [HttpPost]

        public ActionResult CreateProductSold(ProductSold newPS)
        {
            using (ProductFirstVersionEntities dbobj = new ProductFirstVersionEntities())
            {
                dbobj.ProductSolds.Add(newPS);
                dbobj.SaveChanges();
                
                return RedirectToAction("ProductSold");
            }
        }
      
    }
}