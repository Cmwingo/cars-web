using System;
using System.Collections.Generic;

namespace Cars.Objects
{
  class Car
  {
    private string _makeModel;
    private int _price;
    private int _miles;
    private string _description;
    private static List<Car> _inventory = new List<Car> {};

    public void SetMakeModel(string newMakeModel)
    {
      _makeModel = newMakeModel;
    }
    public string GetMakeModel()
    {
      return _makeModel;
    }

    public void SetPrice(int newPrice)
    {
      _price = newPrice;
    }
    public int GetPrice()
    {
      return _price;
    }

    public void SetMiles(int newMiles)
    {
      _miles = newMiles;
    }
    public int GetMiles()
    {
      return _miles;
    }

    public void SetDescription(string newDescription)
    {
      _description = newDescription;
    }
    public string GetDescription()
    {
      return _description;
    }

    public static List<Car> GetAll()
    {
      return _inventory;
    }
    public static void ClearAll()
    {
      _inventory.Clear();
    }

    public Car(string newMakeModel, int newPrice, int newMiles, string newDescription)
    {
      SetMakeModel(newMakeModel);
      SetPrice(newPrice);
      SetMiles(newMiles);
      SetDescription(newDescription);
    }
  }

  public class Program
  {
    public static void Main()
    {
      Car porsche = new Car("2014 Porsche 911", 114991, 7864, "Like the fastest black toad you've ever seen.");

      Car ford = new Car("2011 Ford F450", 55995, 14241, "Perfect for hauling all your big shit.");

      Car lexus = new Car("2013 Lexus RX 350", 44700, 20000, "Perfect 'Mom' car.");

      Car mercedes = new Car("Mercedes Benz CLS550", 39900, 37979, "Affordable old-man car.");

      Car bmw = new Car("BMW X1", 20000, 0, "Sporty, young, you know you want it.");

      List<Car> Cars = new List<Car>() { porsche, ford, lexus, mercedes, bmw };
      foreach(Car automobile in Cars)
      {
        Console.WriteLine(automobile.GetMakeModel());
        Console.WriteLine(automobile.GetDescription());
      }

      Console.WriteLine("Enter maximum price: ");
      string stringMaxPrice = Console.ReadLine();
      int maxPrice = int.Parse(stringMaxPrice);

      Console.WriteLine("Enter maximum miles: ");
      string stringMaxMiles = Console.ReadLine();
      int maxMiles = int.Parse(stringMaxMiles);

      List<Car> CarsMatchingSearch = new List<Car>(0);

      foreach (Car automobile in Cars)
      {
        if (automobile.GetPrice() < maxPrice && automobile.GetMiles() < maxMiles)
        {
          CarsMatchingSearch.Add(automobile);
        }
      }

      foreach(Car automobile in CarsMatchingSearch)
      {
        Console.WriteLine(automobile.GetMakeModel());
      }

      if(CarsMatchingSearch.Count == 0)
      {
        Console.WriteLine("Sorry, No cars match your search paramaters.");
      }
    }
  }
}
