using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EFCore2.Models
{
    public class Books
    {
        [Key]
        [Required]
        public int BID { get; set; }
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public string PublishingAgency { get; set; }

    }
}
