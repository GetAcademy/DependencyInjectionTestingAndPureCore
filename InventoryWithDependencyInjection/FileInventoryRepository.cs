namespace InventoryWithDependencyInjection
{
    internal class FileInventoryRepository : IInventoryRepository
    {
        public int GetStock(string itemId)
        {
            var fileName = FileNameFromItemId(itemId);
            if (!File.Exists(fileName)) return 0;
            return Convert.ToInt32(File.ReadAllText(fileName));
        }

        public void UpdateStock(string itemId, int stock)
        {
            var fileName = FileNameFromItemId(itemId);
            File.WriteAllText(fileName, stock.ToString());
        }

        private static string FileNameFromItemId(string itemId)
        {
            return $@"inventory\{itemId}.txt";
        }
    }
}
