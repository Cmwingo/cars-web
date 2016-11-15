using System;
using System.Collections.Generic;

namespace Cars.Objects
{
  public class Car
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
      _inventory.Add(this);
    }
  }

  // public class Program
  // {
  //   public static void Main()
  //   {
  //
  //     foreach(Car automobile in Cars)
  //     {
  //       Console.WriteLine(automobile.GetMakeModel());
  //       Console.WriteLine(automobile.GetDescription());
  //     }
  //
  //     Console.WriteLine("Enter maximum price: ");
  //     string stringMaxPrice = Console.ReadLine();
  //     int maxPrice = int.Parse(stringMaxPrice);
  //
  //     Console.WriteLine("Enter maximum miles: ");
  //     string stringMaxMiles = Console.ReadLine();
  //     int maxMiles = int.Parse(stringMaxMiles);
  //
  //     List<Car> CarsMatchingSearch = new List<Car>(0);
  //
  //     foreach (Car automobile in Cars)
  //     {
  //       if (automobile.GetPrice() < maxPrice && automobile.GetMiles() < maxMiles)
  //       {
  //         CarsMatchingSearch.Add(automobile);
  //       }
  //     }
  //
  //     foreach(Car automobile in CarsMatchingSearch)
  //     {
  //       Console.WriteLine(automobile.GetMakeModel());
  //     }
  //
  //     if(CarsMatchingSearch.Count == 0)
  //     {
  //       Console.WriteLine("Sorry, No cars match your search paramaters.");
  //     }
  //   }
  // }
}
