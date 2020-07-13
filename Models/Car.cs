using System;

namespace Dealership.Models {
  public class Car
  {
    private string _makeModel;
    private int _price;
    private int _miles;
    public void SetPrice(int newPrice)
    {
      _price = newPrice;
    }
    public Car(string makeModel, int price, int miles)
    {
      _makeModel = makeModel;
      _price = price;
      _miles = miles;
    }
    public static string MakeSound(string sound)
    {
      return "Our cars sound like " + sound;
    }

    public int GetPrice()
    {
      return _price;
    }

    public int GetMiles()
    {
      return _miles;
    }

    public bool WorthBuying(int maxPrice)
    {
      return (_price < maxPrice);
    }
      public string GetMakeModel()
    {
      return _makeModel;
    }
  }

}