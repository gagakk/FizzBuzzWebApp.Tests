using FizzBuzz;

namespace FizzBuzzWebApp.Tests
{
    [TestClass]
    public class FizzBuzzServiceTests
    {
        [TestMethod]
        public void CalculateFizzBuzz_ShouldReturnFizz_WhenMultipleOf3()
        {
            // Arrange
            var fizzBuzzService = new FizzBuzzService();

            // Act
            var result = fizzBuzzService.CalculateFizzBuzz([6]);

            // Assert
            CollectionAssert.AreEqual(new List<string> { "Fizz" }, result);
        }

        [TestMethod]
        public void CalculateFizzBuzz_ShouldReturnBuzz_WhenMultipleOf5()
        {
            // Arrange
            var fizzBuzzService = new FizzBuzzService();

            // Act
            var result = fizzBuzzService.CalculateFizzBuzz([10]);

            // Assert
            CollectionAssert.AreEqual(new List<string> { "Buzz" }, result);
        }

        [TestMethod]
        public void CalculateFizzBuzz_ShouldReturnFizzBuzz_WhenMultipleOf3And5()
        {
            // Arrange
            var fizzBuzzService = new FizzBuzzService();

            // Act
            var result = fizzBuzzService.CalculateFizzBuzz([15]);

            // Assert
            CollectionAssert.AreEqual(new List<string> { "FizzBuzz" }, result);
        }

        [TestMethod]
        public void CalculateFizzBuzz_ShouldReturnDivisionResults_WhenNotMultipleOf3Or5()
        {
            // Arrange
            var fizzBuzzService = new FizzBuzzService();

            // Act
            var result = fizzBuzzService.CalculateFizzBuzz(new List<object> { 7 });

            // Assert
            CollectionAssert.AreEqual(new List<string> { "Divided 7 by 3", "Divided 7 by 5" }, result);
        }

        [TestMethod]
        public void CalculateFizzBuzz_ShouldReturnInvalidItem_WhenInputIsNotNumber()
        {
            // Arrange
            var fizzBuzzService = new FizzBuzzService();

            // Act
            var result = fizzBuzzService.CalculateFizzBuzz(["A"]);

            // Assert
            CollectionAssert.AreEqual(new List<string> { "Invalid Item" }, result);
        }

        [TestMethod]
        public void CalculateFizzBuzz_ShouldReturnInvalidItem_WhenInputIsEmpty()
        {
            // Arrange
            var fizzBuzzService = new FizzBuzzService();

            // Act
            var result = fizzBuzzService.CalculateFizzBuzz([""]);

            // Assert
            CollectionAssert.AreEqual(new List<string> { "Invalid Item" }, result);
        }

    }
}