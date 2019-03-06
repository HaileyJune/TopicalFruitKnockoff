using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TopicalFruitKnockoff.Models;

namespace TopicalFruitKnockoff.Models
{
    public class Catagory
    {
        [Key]
        public int CatagoryId{get;set;}
        public string Name {get; set;}
        public string Desctiption {get;set;}
        public string ImgUrl {get;set;}
    }
}