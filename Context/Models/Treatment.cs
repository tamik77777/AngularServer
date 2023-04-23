namespace Context.Models
{
    public class Treatment
    {
        public int Id { get; set; }
        public string Kind { get; set; }
        public string TzPatient { get; set; }
        public int IdDoctor { get; set; }
        public string DayS { get; set; }
        public int Day { get; set; }
        public string Hour { get; set; }
    }
}
