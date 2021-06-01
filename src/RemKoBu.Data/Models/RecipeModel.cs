namespace RemKoBu.Data.Models
{
    public class RecipeModel
    {
        public int RecipeId { get; set; }
        public string RecipeName { get; set; }
        public int PreperationtimeInMinutes { get; set; }
        public string Method { get; set; }
        public int Rating { get; set; }
        public int Cooked { get; set; }
        public string ImagePath { get; set; }
        public int DifficultyLevel { get; set; }
        public int MarkedForCooking { get; set; }
        public int ServingAmount { get; set; }
        public string ServingType { get; set; }
    }
}