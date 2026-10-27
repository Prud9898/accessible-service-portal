using System.ComponentModel.DataAnnotations;

namespace AccessibleServicePortal.Models;

public class ServiceRequest
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Enter your name.")]
    [StringLength(80, ErrorMessage = "Name must be 80 characters or fewer.")]
    [Display(Name = "Full name")]
    public string FullName { get; set; } = "";

    [Required(ErrorMessage = "Enter an email address.")]
    [EmailAddress(ErrorMessage = "Enter a valid email address.")]
    [Display(Name = "Email address")]
    public string Email { get; set; } = "";

    [Required(ErrorMessage = "Select a request category.")]
    [Display(Name = "Request category")]
    public string Category { get; set; } = "";

    [Required(ErrorMessage = "Describe your request.")]
    [StringLength(1000, MinimumLength = 10, ErrorMessage = "Description must be between 10 and 1,000 characters.")]
    [Display(Name = "Request description")]
    public string Description { get; set; } = "";

    public DateTime CreatedUtc { get; set; } = DateTime.UtcNow;
}
