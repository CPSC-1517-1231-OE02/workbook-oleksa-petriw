using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

using WestWindSystem.DAL;
using WestWindSystem.Entities;

namespace WestWindSystem.BLL
{
    public class ProductServices
    {
        private readonly WestWindContext _context;

        internal ProductServices(WestWindContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Gets products for a category id
        /// </summary>
        /// <returns>List of proucts for a category id</returns>
        public List<Product> GetProductsByCategoryId(int id)
        {
            return _context.Products.Where(p => p.CategoryId == id)
                .Include(p => p.Supplier)
                .ToList<Product>();
        }

        /*public List<Product> GetProductsByNameOrCategoryName(string partial )
        {
            partial = partial.ToLower();
            return _context.Products.Where(p => p.ProductName.ToLower().Contains(partial)
            || p.Category.CategoryName.ToLower().Contains(partial))
                .Include(p => p.Supplier)
                .ToList<Product>();
        }*/

        public List<Product> GetProductsByNameOrSupplierName(string partial)
        {
            partial = partial.ToLower();
            return _context.Products.Where(p => p.ProductName.ToLower().Contains(partial)
            || p.Supplier.CompanyName.ToLower().Contains(partial))
                .Include(p => p.Supplier)
                .ToList<Product>();
        }
    }
}