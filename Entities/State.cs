namespace WebApplication2.Entities
{
    public class State
    {
        public int Id{ get; set; }
        public string Name { get; set; }
        public string Governor { get; set; }
        public  int RegionId{ get; set; }
        public double StateIGR { get; set; }
        public int Population{ get; set; }
        public Region Region{ get; set; }
        
    }
}