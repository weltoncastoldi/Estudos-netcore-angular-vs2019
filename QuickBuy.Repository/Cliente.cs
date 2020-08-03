using QuickBuy.Dominio.Entidades;
using QuickBuy.Repository.Repositorios;

namespace QuickBuy.Repository
{
    public class Cliente
    {
        public Cliente()
        {
            var usuarioRepositorio = new UsuarioRepositorio();
            var cliente = new Usuario();
            usuarioRepositorio.Adicionar(cliente);
        }
    }
}
