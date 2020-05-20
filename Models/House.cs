using System.ComponentModel.DataAnnotations;

namespace fullstack_gregslist.Models
{
    public class House
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int Bedrooms { get; set; }
        [Required]
        public int Bathrooms { get; set; }
        [Required]
        public int Levels { get; set; }
        public int Year { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public string ImgUrl { get; set; }
        public string Body { get; set; }
    }
}