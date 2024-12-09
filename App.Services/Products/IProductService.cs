﻿using App.Repositories;
using App.Repositories.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Services.Products
{
    public interface IProductService 
    {
        Task<ServiceResult<List<ProductDto>>> GetTopPriceProductsAsync(int count);
        Task<ServiceResult<ProductDto>> GetByIdAsync(int id);
        Task<ServiceResult<List<ProductDto?>>> GetAllAsync();
        Task<ServiceResult<List<ProductDto>>> GetPagedAllListAsync(int pageNumber, int pageSize);
        Task<ServiceResult<CreateProductResponse>> CreateAsync(CreateProductRequest request);
        Task<ServiceResult> UpdateAsync(int id, UpdateProductRequest request);
        Task<ServiceResult> UpdateToStockAsync(UpdateProductStockRequest request);
        Task<ServiceResult> DeleteAsync(int id);
    }
}
