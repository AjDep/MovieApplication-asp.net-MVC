namespace Movie.Models
{
    public class Movie
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int StartDate { get; set; }
        public int EndDate { get; set; }
        public int Price { get; set; }
        public string? CinemaName { get; set; }
        public string? MovieActors { get; set; }
        public string? MovieCategory { get; set; }
        public string? MovieProducer { get; set; }
    }
}
