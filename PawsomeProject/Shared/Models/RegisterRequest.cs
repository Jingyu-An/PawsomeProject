using System.ComponentModel.DataAnnotations;

namespace PawsomeProject.Shared.Models;

public class RegisterRequest
{
    [Required]
    public string FirstName { get; set; }
    
    [Required]
    public string LastName { get; set; }
    
    [Required]
    public string UserName { get; set; }
    
    [Required]
    public string Password { get; set; }
    
    [Required]
    [Compare(nameof(Password), ErrorMessage = "Passwords do not match!")]
    public string PasswordConfirm { get; set; }
    
    [Required]
    public string Email { get; set; }
    
    public string? PhoneNumber { get; set; }
}