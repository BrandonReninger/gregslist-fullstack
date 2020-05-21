using System.ComponentModel.DataAnnotations;

namespace fullstack_gregslist.Models
{
    public class Job
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public int Salary { get; set; }
        [Required]
        public int HoursWeek { get; set; }
        [Required]
        public string CityState { get; set; }
        public string Body { get; set; }
    }
}