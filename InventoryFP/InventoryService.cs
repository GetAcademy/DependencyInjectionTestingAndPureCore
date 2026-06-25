using InventoryFP.IntroErrorHandling;

namespace InventoryFP
{
    public static class InventoryService
    {
        public static int Buy(int quantity, int stock)
        {
            if (quantity > stock) return stock;
            var newStock = stock - quantity;
            return newStock;
        }

        public static Result<int> Buy2(int quantity, int stock)
        {
            if (quantity > stock) return Result<int>.Failure("Ikke nok på lager");
            var newStock = stock - quantity;
            return Result<int>.Success(newStock);
        }
    }
}
