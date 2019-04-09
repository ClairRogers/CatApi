using System.Collections.Generic;
using catapi.Models;

namespace catapi.DataBase
{

  public static class Data
  {
    public static List<Cat> Cats = new List<Cat>()
        {
            new Cat(1, "Turtle", "Domestic Shorthair", 4),
            new Cat(2, "Cisco", "Calico", 11),
            new Cat(3, "Rhodes", "Maine Coon", 3)
        };

  }
}