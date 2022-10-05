using System.Collections.Generic;

namespace BestRestaurants.Models
{
  public class Cuisine 
  {
    public Cuisine()
    {
      this.Restaurants = new HashSet<Restaurant>();
    }
      public string Name { get; set; }
      public string Description { get; set; }
      public int CuisineId { get; set; }

      public virtual ICollection<Restaurant> Restaurants { get; set; }
    
  }
}