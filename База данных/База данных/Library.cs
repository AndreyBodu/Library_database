using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace База_данных
{
    public class Library
    {
        public int Id { get; set; }
        public int  BookId { get; set; }
        public int  ClientsId { get; set; }


        
    }
}
