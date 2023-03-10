using System.ComponentModel.DataAnnotations;

namespace SevenApi.Dtos
{
    public class PlatformCreateDto
    {
        [Required]
        public string? PlatformName { get; set; }
    }
}