using System.ComponentModel.DataAnnotations;

namespace TestCasePlatform.Web.Frontend.Models
{
    public class CreateTestProjectViewModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(256, ErrorMessage = "The {0} should be between {1} and {2} characters long", MinimumLength = 6)]
        public string Title { get; set; }

        [StringLength(1024, ErrorMessage = "The {0} maximum is {1} characters")]
        public string Description { get; set; }
    }
}