namespace WebApplication1.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> Instructions { get; set; }//שלבי ההכנה
        public List<Ingredient> Ingredients { get; set; }//רכיבים
        public double TotalTime { get; set; }// זמן ההכנה
    }
}
