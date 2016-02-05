using Data.AdventureWorks;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;

namespace WebApi.AdventureWorks.Controllers
{
    public class ProductsController : ApiController
    {
        private AdventureWorksEntities _context;

        public ProductsController()
        {
            _context = new AdventureWorksEntities();
        }

        // GET: api/Products
        public object Get()
        {
            try
            {
                return new
                {
                    Data = _context.Products.OrderByDescending(p => p.ModifiedDate).Take(10).Select(p => new { p.ProductID, p.Name, p.ListPrice }),
                    Success = true
                };
            }
            catch (Exception ex)
            {
                return new
                {
                    Success = false,
                    ErrorMessage = ex.Message
                };
            }
        }

        // GET: api/Products/5
        public object Get(int id)
        {
            try
            {
                var product = _context.Products.Find(id);

                return new
                {
                    Data = new { product.ProductID, product.Name, product.ListPrice },
                    Success = true
                };

            }
            catch (Exception ex)
            {
                return new
                {
                    Success = false,
                    ErrorMessage = ex.Message
                };
            }
        }

        // POST: api/Products
        public void Post([FromBody]string value)
        {

        }

       // [IdentityBasicAuthentication]
        // PUT: api/Products/5
        public object Put(int id, Product product)
        {
            try
            {
                var existingProduct = _context.Products.Find(id);
                existingProduct.Name = product.Name;
                existingProduct.ListPrice = product.ListPrice;

                _context.SaveChanges();

                return new
                {
                    Success = true
                };

            }
            catch (Exception ex)
            {
                return new
                {
                    Success = false,
                    ErrorMessage = ex.Message
                };
            }
        }

        // DELETE: api/Products/5
        public void Delete(int id)
        {

        }

        [Route("async/products/{id}")]
        public async Task<object> GetAsync(int id)
        {
            try
            {
                var product = await _context.Products.FindAsync(id);
                return new
                {
                    Data = new { product.ProductID, product.Name, product.ListPrice },
                    Success = true
                };
            }
            catch (Exception ex)
            {
                return new
                {
                    Success = false,
                    ErrorMessage = ex.Message
                };
            }
        }

    }
}
