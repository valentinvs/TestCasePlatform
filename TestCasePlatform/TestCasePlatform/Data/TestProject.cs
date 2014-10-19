using System.ComponentModel.DataAnnotations;

namespace TestCasePlatform.Data
{
    public class TestProject
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(256)]
        public string Title { get; set; }

        [StringLength(1024)]
        public string Description { get; set; }
    }
}
