namespace ReportApp.Models
{
    public class Venta
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string? Producto { get; set; }
        public decimal Monto { get; set; }
    }
}