namespace Model.Entity
{
    public class PedidoLivro
    {
        public int PedidoId { get; set; }
        public Pedido Pedido { get; set; }

        public int LivroId { get; set; }
        public Livro Livro { get; set; }
    }
}
