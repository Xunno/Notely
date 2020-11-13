using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NoteApp.Models;

namespace NoteApp.Services
{
    public class ProductServices
    {
        public Product getProductDetail()
        {
            Product product = new Product("sun glass", "nice one");

            return product;
        }
    }
}
