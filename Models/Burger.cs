using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace burgerShackCSharp.Models
{
  public class Burger
  {
    public Burger(string name, int price, int id, int patties, bool lettuce, bool tomato, bool pickle, bool onion, bool ketchup, bool mustard)
    {
      Price = price;
      Id = id;
      Patties = patties;
      Lettuce = lettuce;
      Tomato = tomato;
      Pickle = pickle;
      Onion = onion;
      Ketchup = ketchup;
      Mustard = mustard;
      Name = name;
    }
    [Required]
    [MaxLength(50)]
    public string Name { get; set; }
    [Required]
    public int Price { get; set; }
    [Required]
    public int Id { get; set; }
    public int Patties { get; set; }
    public bool Lettuce { get; set; }
    public bool Tomato { get; set; }
    public bool Pickle { get; set; }
    public bool Onion { get; set; }
    public bool Ketchup { get; set; }
    public bool Mustard { get; set; }
  }

}