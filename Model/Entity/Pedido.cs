namespace Model.Entity
{
    public class Pedido
    {
        public int Id { get; set; }
        // outras propriedades do pedido

        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
    }
}
