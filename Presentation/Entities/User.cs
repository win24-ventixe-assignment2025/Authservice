using System.ComponentModel.DataAnnotations;

namespace Presentation.Entities;

public class User
{
    [Key]
    public Guid Id { get; set; }
    [Required, EmailAddress]
    public string Email { get; set; } = null!;
    [Required]
    public string PasswordHash { get; set; } = null!;
    [Required]
    public string Role { get; set; } = string.Empty;

    public string? RefreshToken { get; set; }
    public DateTime? RefreshtokenExpiryTime { get; set; }
}

