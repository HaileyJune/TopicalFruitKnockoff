using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TopicalFruitKnockoff.Models;

namespace TopicalFruitKnockoff.Models
{
    public class Order
    {
        [Key]
        public int OrderId{get;set;}
        public List<Item> Items{get;set;}
    }
}