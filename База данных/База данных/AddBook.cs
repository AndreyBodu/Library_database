using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace База_данных
{
    public class AddBook
    {
        public int Id { get; set; }
        [Required]
        public string Book_genre { get; set; }
        [Required]
        public string Name_Books { get; set; }
        [Required]
        public string Books_Author { get; set; }
    }
}
