using InventoryFP;

Console.WriteLine("Enkelt lagersystem");
Console.WriteLine();

Console.Write("Hvilken vare vil du kjøpe? ");
var itemId = Console.ReadLine();

Console.Write("Hvor mange vil du kjøpe? ");
var quantity = Convert.ToInt32(Console.ReadLine());

var fileName = $@"inventory\{itemId}.txt";
var stock = 0;
if (File.Exists(fileName)) stock = Convert.ToInt32(File.ReadAllText(fileName));

var result = InventoryService.Buy2(quantity, stock);

if (result.IsSuccess)
{
    var newStock = result.Value.ToString();
    File.WriteAllText(fileName, newStock);
}

Console.WriteLine();

var message = result.IsSuccess ? "Kjøpet ble gjennomført." : "Det er ikke nok på lager.";
Console.WriteLine(message);

/*
 
   using InventoryFP;
   
   Console.WriteLine("Enkelt lagersystem");
   Console.WriteLine();
   
   Console.Write("Hvilken vare vil du kjøpe? ");
   var itemId = Console.ReadLine();
   
   Console.Write("Hvor mange vil du kjøpe? ");
   var quantity = Convert.ToInt32(Console.ReadLine());
   
   var fileName = $@"inventory\{itemId}.txt";
   var stock = 0;
   if (File.Exists(fileName)) stock = Convert.ToInt32(File.ReadAllText(fileName));
   
   var newStock = InventoryService.Buy(quantity, stock);
   
   var hasBought = newStock < stock;
   if (hasBought)
   {
       File.WriteAllText(fileName, newStock.ToString());
   }
   
   Console.WriteLine();
   
   var message = newStock < stock ? "Kjøpet ble gjennomført." : "Det er ikke nok på lager.";
   Console.WriteLine(message); 
 */