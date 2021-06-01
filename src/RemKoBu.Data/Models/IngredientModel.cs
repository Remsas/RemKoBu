namespace RemKoBu.Data.Models
{
    public class IngredientModel
    {
        public int IngredientId { get; set; }
        public int IngredientCategoryId { get; set; }
        public string IngredientName { get; set; }
        public int KcalPer100G { get; set; }
        public int ChPer100G { get; set; }
        public int PrPer100G { get; set; }
        public int FatPer100G { get; set; }
        public string ImagePath { get; set; }
    }
}