using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace demo.Models
{
    //relationship: University - Student : One - Many
    public class University
    {
        public int Id { get; set; } //Primary key

        [Required]
        [Display(Name = "University Name")]
        public string Name { get; set; }

        public string Address { get; set; }

        [Required]
        public string Logo { get; set; }

        //khai báo ICollection để kết nối đến Student từ University
        public ICollection<Student> Students { get; set; }
    }
}
