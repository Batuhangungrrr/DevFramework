﻿using DevFramework.Northwind.Business.Abstract;
using DevFramework.Northwind.Business.DependenyResolvers.Ninject;
using DevFramework.Northwind.Business.ServiceContracts.Wcf;
using DevFramework.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ProductDetailService
/// </summary>
public class ProductDetailService : IProductServiceDetailService
{
    IProductService _productService = InstanceFactory.GetInstance<IProductService>();
    public List<Product> GetAll()
    {
        return _productService.GetAll();
    }
}