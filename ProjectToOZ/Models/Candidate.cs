namespace ProjectToOZ.Models
{
    public enum Languages
    {
        c,angular,python,react,js,java,delphy
    }
    public class Candidate
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime? BeginYear { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public List<Languages> Languages { get; set; }
        

    }
}
