using EjercicioDBM2;

//3 productos de precio estático (fp1, fp2, fp3)
#region 
Product fp1 = new FixedPriceProduct
{
    Description = "Botella de vino Cabernet Sauvignon",
    Id = 111,
    Price = 85000,
    Tax = 0.19,

};

Product fp2 = new FixedPriceProduct
{
    Description = "Bolsa de Maní salado La especial",
    Id= 222,
    Price = 9500,
    Tax = 0.19,
};

Product fp3 = new FixedPriceProduct
{
    Description = "Barra de chocolate Hershey's grande",
    Id = 333,
    Price = 20000,
    Tax = 0.19,
};

//Console.WriteLine("Los productos de precio estático: \n");
//Console.WriteLine(fp1);
//Console.WriteLine(fp2);
//Console.WriteLine(fp3);

#endregion


//2 productos de precio variable (vp4, vp5)
#region
Product vp4 = new VariablePriceProduct
{
    Description = "Uvas chilenas",
    Id = 444,
    Price = 13000,
    Mesasurement = "Kilo",
    Quantity = 2.5M,
    Tax = 0.19,
};

Product vp5 = new VariablePriceProduct
{
    Description = "Queso cheddar",
    Id = 555,
    Price = 50000,
    Mesasurement = "Kilo",
    Quantity = 0.5M,
    Tax = 0.19,
};

//Console.WriteLine("\nLos productos de precio variable: \n");
//Console.WriteLine(vp1);
//Console.WriteLine(vp2);

#endregion


//1 producto compuesto “Ancheta” (cp6)
#region
Product cp6 = new CompoundProducts
{
    Description = "Ancheta",
    Discount = 0.12,
    Id = 666,
    Products = new List<Product>() { fp1, fp2,vp5 },
};

//Console.WriteLine("\nProducto Compuesto: \n");
//Console.WriteLine(cp1);

#endregion

Console.WriteLine("INVOICE # 1");
Console.WriteLine("-------------------------------------------------");

Invoice invoice1 = new Invoice();
invoice1.AddProduct(fp1);
invoice1.AddProduct(fp2);
invoice1.AddProduct(fp3);
invoice1.AddProduct(vp4);
invoice1.AddProduct(vp5);
Console.WriteLine(invoice1);


Console.WriteLine("\n*************************************************\n");

Console.WriteLine("INVOICE # 2");
Console.WriteLine("-------------------------------------------------");

Invoice invoice2 = new Invoice();
invoice2.AddProduct(cp6);
invoice2.AddProduct(fp3);
invoice2.AddProduct(vp4);
Console.WriteLine(invoice2);

