using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoList.Models;

namespace ToDoList.Tests
{
  [TestClass]
  public class ItemTests
  {
    [TestMethod]
    public void ItemConstructor_CreatesInstanceOfitem_Item()
    {
      Item newItem = new Item();
      Assert.AreEqual(typeof(Item), newItem.GetType());
    }
    [TestMethod] // method being tested, describe behavior, expected value
    public void GetDescription_ReturnsDescription_String()
    {
      // Arrange
      string description = "Walk the Dog.";
      Item newItem = new Item(description);
      // Act
      string result = newItem.Description;
      // Assert
      Assert.AreEqual(description, result);
    }
  }
}