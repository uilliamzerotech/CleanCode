﻿namespace Model.Entity
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        // outras propriedades do cliente

        public ICollection<Pedido> Pedidos { get; set; }
    }
}
