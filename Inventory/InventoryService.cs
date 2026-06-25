namespace Inventory
{
    public static class InventoryService
    {
        public static bool Buy(string itemId, int quantity)
        {
            var fileName = $@"inventory\{itemId}.txt";

            var stock = 0;
            if (File.Exists(fileName)) stock = Convert.ToInt32(File.ReadAllText(fileName));

            if (quantity > stock) return false;

            var newStock = stock - quantity;

            File.WriteAllText(fileName, newStock.ToString());

            return true;
        }
    }
}
