namespace TopicalFruitKnockoff.Models
{
    public class Item
    {
        public int ItemId {get;set;}
        public string Name {get;set;}
        public string Description {get;set;}
        public string ImgUrl {get;set;}
        public double Price {get;set;}
        public int CatagoryId {get;set;}
        public Catagory Catagory {get;set;}
    }
}