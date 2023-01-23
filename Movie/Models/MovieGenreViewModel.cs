using Microsoft.AspNetCore.Mvc.Rendering;
using Movie.Models;
using System.Collections.Generic;

namespace MovieGenreViewModel.Models;

public class MovieGenreViewModels
{
    public List<MoviesModel>? Movies { get; set; }
    public SelectList? Genres { get; set; }
    public string? MovieGenre { get; set; }
    public string? SearchString { get; set; }
}