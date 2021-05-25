namespace RemKoBu.Data.Models
{
    public class RecipeModel
    {
        public int recipe_id { get; set; }
        public string recipe_name { get; set; }
        public int preperationtime_in_minutes { get; set; }
        public string method { get; set; }
        public int rating { get; set; }
        public int cooked { get; set; }
        public string image_path { get; set; }
        public int difficulty_level { get; set; }
        public int marked_for_cooking { get; set; }
        public int serving_count { get; set; }
        public string serving_type { get; set; }
    }
}