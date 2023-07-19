using APC_.Data;
using APC_.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APC_.Controller
{
    public class ProductController
    {
        private readonly DataContext _context;

        public ProductController (DataContext context)
        {
            _context = context;
        }

        public void Add(Product product)
        {
            try
            {
                _context.Add(product);
                _context.SaveChanges();
                Console.WriteLine("Add product successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Add product failed: " + ex.Message);
            }
        }

        public void GetAllProducts()
        {
            var products = _context.Products.ToList();
            foreach (var item in products)
            {
                Console.WriteLine($" ProductID:{item.Id}  Name:{item.Name}  Price:{item.Price}");
            }
        }

        public void DeleteProduct( int id )
        {
        
            Product deleteProduct = (Product)_context.Products.Where(p => p.Id == id)
                                         .Single();
            
                try
                {
                    _context.Products.Remove(deleteProduct);
                    _context.SaveChanges();
                    Console.WriteLine("Delete success");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }


        }

    }
}
