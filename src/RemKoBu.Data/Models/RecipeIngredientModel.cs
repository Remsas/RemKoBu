namespace RemKoBu.Data.Models
{
    public class RecipeIngredientModel
    {
        public int RecipeIngredientId { get; set; }
        public int RecipeId { get; set; }
        public int IngredientId { get; set; }
        public int IngredientQuantity { get; set; }
        public string IngredientMeasureUnit { get; set; }
        public int GrammPerIngredientMeasureUnit { get; set; }
    }
}