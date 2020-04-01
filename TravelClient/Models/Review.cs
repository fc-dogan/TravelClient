using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace TravelClient.Models
{
  public class Review
  {
    public int ReviewId {get; set;}
  
    public string Country { get; set; }
  
    public string City { get; set; }
  
    public string Author {get; set;}
  
    public int Rating {get; set;}
  
    public string Description {get; set;}
  
    public static List<Review> GetReviews()
    {
      var apiCallTask = ApiHelper.GetAll();
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Review> reviewList = JsonConvert.DeserializeObject<List<Review>>(jsonResponse.ToString());

      return reviewList;
    }

    public static Review GetDetails(int id)
    {
      var apiCallTask = ApiHelper.Get(id);
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      Review review = JsonConvert.DeserializeObject<Review>(jsonResponse.ToString());

      return review;
    }

    // public static void Post(Animal animal)
    // {
    //   string jsonAnimal = JsonConvert.SerializeObject(animal);
    //   var apiCallTask = ApiHelper.Post(jsonAnimal);
    // }

    // public static void Put(Animal animal)
    // {
    //   string jsonAnimal = JsonConvert.SerializeObject(animal);
    //   var apiCallTask = ApiHelper.Put(animal.AnimalId, jsonAnimal);
    // }

    // public static void Delete(int id)
    // {
    //   var apiCallTask = ApiHelper.Delete(id);
    // }
  }
}