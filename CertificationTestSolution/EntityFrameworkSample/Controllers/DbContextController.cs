using EntityFrameworkSample.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace EntityFrameworkSample.Controllers
{
    public class DbContextController : Controller
    {
        private AdventureWorksEntities _context;
        private bool _lazyLoadingEnabled;

        public DbContextController()
        {
            _context = new AdventureWorksEntities();
            _lazyLoadingEnabled = _context.Configuration.LazyLoadingEnabled;
        }

        public ActionResult Index()
        {
            return View();
        }

        // GET: ProductCategories
        public ActionResult Query()
        {
            var categories = _context.ProductCategories.OrderByDescending(c => c.ModifiedDate).Take(10).ToList();
            return View(categories);
        }

        // GET: ProductCategories/Create
        public ActionResult Create()
        {
            AddCategoriesDDL();
            return View();
        }

        private void AddCategoriesDDL()
        {
            var categories = _context.ProductCategories.ToList();
            ViewBag.ParentProductCategoryID = new SelectList(categories, "ProductCategoryID", "Name");
        }

        // POST: ProductCategories/Create
        [HttpPost]
        public ActionResult Create(ProductCategory model)
        {
            if (ModelState.IsValid)
            {
                var retry = 0;
                Exception exception = null;
                while(retry < 5)
                {
                    try
                    {
                        model.ModifiedDate = DateTime.Now;
                        model.rowguid = Guid.NewGuid();
                        _context.ProductCategories.Add(model);
                        _context.SaveChanges();
                        return RedirectToAction("Query");
                    }
                    catch (Exception ex)
                    {
                        exception = ex;
                        retry++;
                    }
                }
                if(exception != null)
                    ModelState.AddModelError("", exception.ToString());
            }

            AddCategoriesDDL();
            return View(model);         
        }

        // GET: ProductCategories/Delete/5
        public ActionResult Delete(int id)
        {
            var category = _context.ProductCategories.FirstOrDefault(pc => pc.ProductCategoryID == id);
            if(category != null)
            {
                _context.ProductCategories.Remove(category);
                _context.SaveChanges();
            }
            return RedirectToAction("Query");
        }

        public ActionResult LazyLoading(string status = null)
        {
            IEnumerable<Product> products;
            if(!string.IsNullOrEmpty(status) && status == "include")
            {
                _context.Configuration.LazyLoadingEnabled = false;
                //include category and model for all products
                products = _context.Products.Include("ProductCategory").Include("ProductModel").OrderBy(p => p.Name).Take(10).ToList();
            }
            else if (!string.IsNullOrEmpty(status) && status == "reference")
            {
                _context.Configuration.LazyLoadingEnabled = false;
                products = _context.Products.OrderBy(p => p.Name).Take(10).ToList();

                //load product category and model for first product
                var product = products.FirstOrDefault();
                _context.Entry(product).Reference("ProductCategory").Load();
                _context.Entry(product).Reference("ProductModel").Load();

            }
            else if (!string.IsNullOrEmpty(status) && status == "off")
            {
                _context.Configuration.LazyLoadingEnabled = false;
                products = _context.Products.OrderBy(p => p.Name).Take(10).ToList();
            }
            else
            {
                _context.Configuration.LazyLoadingEnabled = true;
                products = _context.Products.OrderBy(p => p.Name).Take(10).ToList();
                
            }
            return View(products);
        }

        public ActionResult EntitySQL(int id = 0)
        {
            string esqlQuery = @"SELECT VALUE customers FROM AdventureWorksEntities.Customers AS customers  WHERE customers.CustomerID == @id";

            var customers = new List<Customer2>();
            using(var conn = new EntityConnection("name=AdventureWorksEntities"))
            {
                conn.Open();

                using(var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = esqlQuery;
                    var param = new EntityParameter {
                        ParameterName = "id",
                        Value = id
                    };
                    cmd.Parameters.Add(param);

                    using(var reader = cmd.ExecuteReader(System.Data.CommandBehavior.SequentialAccess))
                    {
                        while (reader.Read())
                        {
                            var customer = new Customer2
                            {
                                CustomerID = int.Parse(reader["CustomerID"].ToString()),
                                CustomerName = reader["FirstName"] + " " + reader["MiddleName"] + " " + reader["LastName"]
                            };

                            customers.Add(customer);
                        }
                    }
                }

                conn.Close();
            }

            return View(customers);
        }

        public async Task<ActionResult> GetAsync(int id = 0)
        {
            var task = GetCustomersAsync(id);

            //Do other operations
            var e = 3 + 3;
            var f = e % 4;

            var result = await task;
            return View(result);
        }

        public async Task<Customer> GetCustomersAsync(int customerId)
        {
            return await _context.Customers.FindAsync(customerId);
        }

        public ActionResult StoredProcedures()
        {
            var categories = _context.ufnGetAllCategories();
            var customer = _context.ufnGetCustomerInformation(1);

            var model = new StoredProcedureViewModel
            {
                Categories = categories.ToList(),
                Customer = customer.FirstOrDefault()
            };
            return View(model);
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
            base.Dispose(disposing);
        }
    }
}
