namespace RemKoBu.Data.Models
{
    public class RecipeSpiceModel
    {
        public int RecipeSpiceId { get; set; }
        public int RecipeId { get; set; }
        public int SpiceId { get; set; }
        public int SpiceQuantity { get; set; }
        public string SpiceMeasureUnit { get; set; }
    }
}