using InventoryWithDependencyInjection;

namespace InventoryDI.Test
{
    internal class FakeInventoryRepository : IInventoryRepository
    {
        public int Stock { get; private set; }
        public int StockUpdated { get; private set; }

        public FakeInventoryRepository(int stock)
        {
            Stock = stock;
        }

        public int GetStock(string itemId)
        {
            return Stock;
        }

        public void UpdateStock(string itemId, int stock)
        {
            Stock = stock;
            StockUpdated++;
        }
    }
}
