using LojaVirtual.Dominio.Entidade;

namespace LojaVirtual.Web.Models
{
    public class CarrinhoViewModel
    {
        public Carrinho carrinho { get; set; }

        public string ReturnUrl { get; set; }
    }
}