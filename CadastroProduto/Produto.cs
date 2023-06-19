using System;

namespace CadastroProduto
{
    class Produto{
        public int Id { get; set; }
        public string Descricao { get; set; }
        public double Preco { get; set; }
        public int Estoque { get; set; }
        public int IdCategoria { get; set; }
        public override string ToString() {
            return $"ID: {Id} - Produto: {Descricao} - Preço: {Preco} - Estoque: {Estoque} - IDCategoria: {IdCategoria}";
        }
    }
}
