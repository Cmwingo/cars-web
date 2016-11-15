using Nancy;
using Cars.Objects;
using System.Collections.Generic;

namespace Cars
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Dictionary<string, object> Inventory = new Dictionary<string, object>();
      Car porsche = new Car("2014 Porsche 911", 114991, 7864, "Like the fastest black toad you've ever seen.");

      Car ford = new Car("2011 Ford F450", 55995, 14241, "Perfect for hauling all your big shit.");

      Car lexus = new Car("2013 Lexus RX 350", 44700, 20000, "Perfect 'Mom' car.");

      Car mercedes = new Car("Mercedes Benz CLS550", 39900, 37979, "Affordable old-man car.");

      Car bmw = new Car("BMW X1", 20000, 0, "Sporty, young, you know you want it.");

      List<Car> currentInventory = Car.GetAll();
      Inventory.Add("CarInventory", currentInventory);
      Get["/"] = _ => View["car_index.cshtml", Inventory];
      Get["/add_car"] = _ => View["add_car.cshtml"];
      Post["/car_added"] = _ =>
      {
        Car newCar = new Car (Request.Form["make-model"], Request.Form["price"], Request.Form["mileage"], Request.Form["description"]);
        return View["car_added.cshtml", newCar];
      };
    }
  }
}
