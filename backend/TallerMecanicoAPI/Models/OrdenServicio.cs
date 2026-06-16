namespace TallerMecanicoAPI.Models
{
    public class OrdenServicio
    {
        public int Id { get; set; }
        public string Descripcion { get; set; } = "";
        public string Estado { get; set; } = "";
        public int VehiculoId { get; set; }
        public int MecanicoId { get; set; }
    }
}