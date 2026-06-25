namespace InventoryWithDependencyInjection
{
    public class InventoryService
    {
        private IInventoryRepository _repo;

        public InventoryService(IInventoryRepository repo)
        {
            _repo = repo;
        }

        public bool Buy(string itemId, int quantity)
        {
            var stock = _repo.GetStock(itemId);
            if (quantity > stock) return false;
            var newStock = stock - quantity;
            _repo.UpdateStock(itemId, newStock);
            return true;
        }

        /*
        public bool Buy(string itemId, int quantity)
        {
            var fileName = $@"inventory\{itemId}.txt";

            var stock = 0;
            if (File.Exists(fileName)) stock = Convert.ToInt32(File.ReadAllText(fileName));

            if (quantity > stock) return false;

            var newStock = stock - quantity;

            File.WriteAllText(fileName, newStock.ToString());

            return true;
        }
        */
    }
}
