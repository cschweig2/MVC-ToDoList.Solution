using System.Collections.Generic;
using System;
using ToDoList.Models;

namespace ToDoList
{
  public class Program
  {
    public static void Main()
    {
      List<Item> toDoList = new List<Item> { };
      Console.WriteLine("Welcome to the To Do List!");
      Console.WriteLine("Would you like to add an item to your list or view your list? (Add/View)");
      string userInput = Console.ReadLine();
      if (userInput == "Add")
      {
        Console.WriteLine("Please enter the description for the new item.");
        string description = Console.ReadLine();
        Item newItem = new Item(description);
        Console.WriteLine(description + " has been added to your list. Would you like to add an item to your list or view your list? (Add/View)");
        userInput = Console.ReadLine();
      }
      if (userInput == "View")
      {
        List<Item> result = Item.GetAll();
        foreach (Item item in result)
        {
          Console.WriteLine(item.Description);
        }
      }
    }
  }
}
