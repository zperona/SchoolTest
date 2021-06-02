using System.ComponentModel.DataAnnotations;

namespace SchoolTest.Models
{
    public class BaseId
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(250)]
        public string Notes { get; set; }
    }
}
