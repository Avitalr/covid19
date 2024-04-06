namespace covid19.web.Models.Entities
{
    public class Patient
    {
        public string full_Name { get; set; }
        public string Id { get; set; }
        public string Address { get; set; }
        public DateTime Date_Of_Birth { get; set; }
        public string Telphone { get; set; }
        public string Mobile_Phone { get; set; }
        public DateTime? Covid_Positive_Date { get; set; }
        public DateTime? Covid_Recovery_Date { get; set; }



    }
}
