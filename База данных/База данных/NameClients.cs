using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace База_данных
{
    public class NameClients
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SureName { get; set; }
        public string NumberPhone { get; set; }

        List<NameClients> clients { get; set; } = [];
    }
}
