using System.Collections.Generic;

namespace WebApplication2.Entities
{
    public class Region
    {
        public int Id{ get; set; }
        public string Name { get; set; }
        //public string Tribe{ get; set; }
        public int Population{ get; set; }
        public long IGR{ get; set; }
        public virtual List<State> States { get; set; } = new List<State>();
    }
}