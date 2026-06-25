namespace InventoryWithDependencyInjection
{
    public interface IInventoryRepository
    {
        int GetStock(string itemId);
        void UpdateStock(string itemId, int stock);
    }
}
