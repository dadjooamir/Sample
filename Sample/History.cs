using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    public class History
    {
        public History() { }
        public Int32 Id { get; set; }
        public string Action { get; set; }
        public DateTime ActionTime { get; set; }
        public string Description { get; set; }
        public Int32 UserId { get; set; }
    }
}
