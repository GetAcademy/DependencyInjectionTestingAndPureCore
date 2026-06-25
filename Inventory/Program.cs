using Inventory;

Console.WriteLine("Enkelt lagersystem");
Console.WriteLine();

Console.Write("Hvilken vare vil du kjøpe? ");
var itemId = Console.ReadLine();

Console.Write("Hvor mange vil du kjøpe? ");
var quantity = Convert.ToInt32(Console.ReadLine());

var success = InventoryService.Buy(itemId, quantity);

Console.WriteLine();

var message = success ? "Kjøpet ble gjennomført." : "Det er ikke nok på lager.";
Console.WriteLine(message);