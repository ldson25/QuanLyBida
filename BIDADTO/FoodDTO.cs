namespace BIDADTO
{
    public class FoodDTO
    {
        public int IdFood { get; set; }
        public string Name { get; set; }
        public int IdCategory { get; set; }
        public double Price { get; set; }
        public string Images { get; set; }

        public string TypeName { get; set; }

        public int Inventory { get; set; } 
        public string Unit { get; set; }   
        public string CategoryName { get; set; } 

        public FoodDTO(int idFood, string name, int idCategory, double price, string images, string typename)
        {
            IdFood = idFood;
            Name = name;
            IdCategory = idCategory;
            Price = price;
            Images = images;
            TypeName = typename;
        }

        public FoodDTO() { }
    }
}