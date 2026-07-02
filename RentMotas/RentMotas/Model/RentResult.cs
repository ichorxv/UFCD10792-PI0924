namespace RentMotas.Model
{
    public class RentResult
    {
        public int Id { get; set; }
        public int Numero { get; set; }
        public string? Nome { get; set; }
        public string? Marca { get; set; }
        public List<RentModelos>?Modelos { get; set; }
        
    }
}
