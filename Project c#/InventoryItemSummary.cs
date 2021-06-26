public class InventoryItemSummary : ProductPurchaseOrder 
{
public static Product SearchProductsByName(string Name, List products) {
  foreach (Product rs in products) 
    if (ProductsName == rs.Name)
      return rs; 

  return null;   


  Console.WriteLine("Enter the name of the product");

  string pname = Console.ReadLine();


  Product res = SearchRestaurantsByName(pname, products);

  if (res != null) 
    Console.WriteLine("The product is found");  
  else 
    Console.WriteLine("The product is not found");  
}
}