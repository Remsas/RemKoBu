namespace RemKoBu.Data.Models
{
    public class Recipe_IngredientModel
    {
        public int recipe_ingredient_id { get; set; }
        public int recipe_id { get; set; }
        public int ingredient_id { get; set; }
        public int ingredient_quantity { get; set; }
        public string ingredient_measureUnit { get; set; }
        public int gramm_per_ingredient_measureUnit { get; set; }
    }
}