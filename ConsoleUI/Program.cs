﻿// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

Console.WriteLine("Hello, World!");

//CategoryTest();


ProductTest();

static void ProductTest()
{
  //  ProductManager productManager = new ProductManager(new EfProductDal(),new CategoryManager(new EfProductDal()));
  //  var result = productManager.GetProductDetails();
    //if(result.Success == true )
    //{
        
    //    foreach (var product in result.Data)
    //    {

    //        Console.WriteLine(product.ProductName + "/" + product.CategoryName);
    //    }
    
    //}
    //else
    //{
    //    Console.WriteLine(result.Message);
    //}

}

static void CategoryTest()
{
    CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

    //foreach (var category in categoryManager.GetAll())
    //{
    //    Console.WriteLine(category.CategoryName);
    //}
}