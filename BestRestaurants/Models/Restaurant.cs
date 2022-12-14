using System.Collections.Generic;

namespace BestRestaurants.Models
{
  public class Restaurant
  {
    public int RestaurantId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string PriceRange { get; set; }
    public string Location { get; set; }
    public bool VeganFriendly { get; set; }
    public bool GlutenFree { get; set; }
    public int CuisineId { get; set; }

    public virtual Cuisine Cuisine { get; set; }
  }
}