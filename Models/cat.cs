using System.ComponentModel.DataAnnotations;

namespace catapi.Models
{
  public class Cat
  {
    [Required]
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string Breed { get; set; }
    [Required]
    public int Age { get; set; }


    public Cat(int id, string name, string breed, int age)
    {
      Id = id;
      Name = name;
      Breed = breed;
      Age = age;
    }
  }
}