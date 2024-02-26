namespace EpiEdil.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public DateTime Periodo { get; set; }
        public decimal Ammontare { get; set; }
        public bool Stipendio { get; set; }
    }
}
