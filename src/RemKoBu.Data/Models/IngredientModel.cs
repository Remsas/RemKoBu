namespace RemKoBu.Data.Models
{
    public class IngredientModel
    {
        public int ingredient_id { get; set; }
        public int ingredientsCategory_id { get; set; }
        public string ingredient_name { get; set; }
        public int kcal_per_100g { get; set; }
        public int ch_per_100g { get; set; }
        public int pr_per_100g { get; set; }
        public int fat_per_100g { get; set; }
        public string image_path { get; set; }
    }
}