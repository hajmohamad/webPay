namespace webPay.Models.PageAttribute;

public class MovieFormViewModel
{
    public Movie Movie { get; set; }
    public IEnumerable<string> GenreList { get; set; }= new List<string>()
    {
        "Action",
        "Comedy",
        "Drama",
        "Horror",
        "Romance",
        "Thriller"
    };

    
}