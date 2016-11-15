using Nancy;
using System;
using Cars.Objects;
using System.Collections.Generic;

namespace Cars
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Dictionary<string, object> Inventory = new Dictionary<string, object>();
      
      Get["/"] = _ => {
        List<Car> currentInventory = Car.GetAll();
        foreach(var car in currentInventory)
        {
          Console.WriteLine(car.GetMakeModel());
        }
        Inventory.Add("CarInventory", currentInventory);
        return View["car_index.cshtml", Inventory];
      };
      Get["/add_car"] = _ => View["add_car.cshtml"];
      Post["/car_added"] = _ =>
      {
        Car newCar = new Car (Request.Form["make-model"], Request.Form["price"], Request.Form["miles"], Request.Form["description"]);
        return View["car_added.cshtml", newCar];
      };
    }
  }
}
