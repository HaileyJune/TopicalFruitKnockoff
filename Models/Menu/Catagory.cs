using System.Collections.Generic;
using TopicalFruitKnockoff.Models;

namespace TopicalFruitKnockoff.Models
{
    public class Catagory
    {
        public int CatagoryId{get;set;}
        public string Name {get; set;}
        public string Desctiption {get;set;}
        public string ImgUrl {get;set;}
        public virtual ICollection<Item> Items { get; set; }
    }
}