namespace RemKoBu.Data.Models
{
    public class Recipe_SpiceModel
    {
        public int recipe_spice_id { get; set; }
        public int recipe_id { get; set; }
        public int spice_id { get; set; }
        public int spice_quantity { get; set; }
        public string spice_measureUnit { get; set; }
    }
}