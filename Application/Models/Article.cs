namespace Application.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Designation { get; set; }
        public string Quantite { get; set; }
        public int prix { get; set; }
        public int taxe { get; set; }
        public string Decision { get; set; }

        public Article()
        {
            // Set default value for Decision
            Decision = "Waiting";
        }
    }
}
