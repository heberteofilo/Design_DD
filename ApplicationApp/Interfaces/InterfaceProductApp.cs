﻿using ApplicationApp.Interfaces.Generics;
using Entities.Entities;
using System.Threading.Tasks;

namespace ApplicationApp.Interfaces
{
    public interface InterfaceProductApp : InterfaceGenericApp<Product>
    {
        Task AddProduct(Product product);
        Task UpdateProduct(Product product);
    }
}
