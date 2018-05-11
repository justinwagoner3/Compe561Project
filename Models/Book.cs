using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JustBooks.Models
{
    public class Book
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "First Name")]
        public string AuthorFirstName { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string AuthorLastName { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Subject")]
        public string Subject { get; set; }

        [Required]
        [Range(0.00,10000.00)]
        [Display(Name = "Price")]
        public decimal Price { get; set; }

        [Display(Name = "Author")]
        public string AuthorFullName
        {
            get
            {
                return AuthorFirstName + " " + AuthorLastName;
            }
        }

    }
}
