using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace MvcMovie.Models;

public class Movie
{
    public int Id { get; set; }

    [Display(Name = "Title", Description = "Name of the Movie")]
    [StringLength(60, MinimumLength = 3)]
    [Required]
    public string? Title { get; set; }

    [Display(Name = "Release Date", Description = "The release date of the Movie")]
    [DataType(DataType.Date)]
    public DateTime ReleaseDate { get; set; }

    [Display(Name = "Genre", Description = "a category that classifies films based on shared characteristics,\n such as themes, styles, settings, or characters")]
    [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$"), StringLength(30)]
    [Required]
    public string? Genre { get; set; }

    [Display(Name = "Price", Description = "The Cost of movie production")]
    [Range(1, 999), DataType(DataType.Currency), Column(TypeName = "decimal(18, 2)")]
    [Required]
    public decimal Price { get; set; }

    [Display(Name = "Review", Description = "Your opinion and evaluation on the Movie")]
    [Column(TypeName = "decimal(3, 1)")]
    [Range(0, 5)]
    [Required]
    public double? Rating { get; set; }
}