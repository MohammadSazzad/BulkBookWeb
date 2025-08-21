using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Bulk.Models;

public class Product
{
    public int Id { get; set; }
    [Required]
    public string Title { get; set; } = string.Empty;
    [Required]
    public string Description { get; set; } = string.Empty;
    [Required]
    public string ISBN { get; set; } = string.Empty;
    [Required]
    public string Author { get; set; } = string.Empty;
    [Required]
    [Display(Name = "List Price")]
    [Range(1, 10000, ErrorMessage = "List Price must be between 1 and 10000")]
    public double ListPrice { get; set; }
    [Required]
    [Display(Name = "Price")]
    [Range(1, 10000, ErrorMessage = "Price must be between 1 and 10000")]
    public double Price { get; set; }
    [Required]
    [Display(Name = "Price for 50")]
    [Range(1, 10000, ErrorMessage = "Price must be between 1 and 10000")]
    public double Price50 { get; set; }
    [Required]
    [Display(Name = "Price for 100")]
    [Range(1, 10000, ErrorMessage = "Price must be between 1 and 10000")]
    public double Price100 { get; set; }

    [Display(Name = "Category")]
    public int CategoryId { get; set; }
    [ForeignKey("CategoryId")]
    public Category? Category { get; set; }
    [Display(Name = "Image URL")]
    [ValidateNever]
    public string ImageUrl { get; set; } = string.Empty;
}
