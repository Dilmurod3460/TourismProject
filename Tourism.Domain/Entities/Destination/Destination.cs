using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tourism.Domain.Entities.Destination
{
    public class Destination
    {
        public int DestinationId { get; set; }
        public string Name { get; set; }
        public string Location {  get; set; }
        public string Rating { get; set; }
        public string ImageURL { get; set; }
    }
}
