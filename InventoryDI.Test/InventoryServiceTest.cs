using InventoryWithDependencyInjection;

namespace InventoryDI.Test
{
    public class Tests
    {
        [Test]
        public void TestBuyLessThanStock()
        {
            // arrange
            var repo = new FakeInventoryRepository(9);
            var inventoryService = new InventoryService(repo);

            // act
            var isSuccess = inventoryService.Buy("1", 3);

            // assert
            Assert.That(isSuccess, Is.True);
            Assert.That(repo.Stock, Is.EqualTo(6));
            Assert.That(repo.StockUpdated, Is.EqualTo(1));
        }

        [Test]
        public void TestBuyMoreThanStock()
        {
            // arrange
            var repo = new FakeInventoryRepository(2);
            var inventoryService = new InventoryService(repo);

            // act
            var isSuccess = inventoryService.Buy("1", 3);

            // assert
            Assert.That(isSuccess, Is.False);
            Assert.That(repo.Stock, Is.EqualTo(2));
            Assert.That(repo.StockUpdated, Is.EqualTo(0));
        }
    }
}
