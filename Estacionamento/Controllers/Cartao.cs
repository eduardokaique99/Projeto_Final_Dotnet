namespace Controllers
{
    public class Cartao {
        public static Models.Cartao CriarCartao(
            string Codigo
        )
        {
            return Models.Cartao.CriarCartao(
                Codigo
            );
        }

        public static Models.Cartao AlterarCartao(
            string id,
            string Codigo
        )
        {
            return Models.Cartao.AlterarCartao(
                int.Parse(id),
                Codigo
            );
        }

        public static Models.Cartao ExcluirCartao(
            string id
        )
        {
            return Models.Cartao.ExcluirCartao(
                int.Parse(id)
            );
        }

        public static Models.Cartao BuscarCartao(
            string id
        ) {
            return Models.Cartao.BuscarCartao(
                int.Parse(id)
            );
        }

        public static IEnumerable<Models.Cartao> BuscarCartaos()
        {
            return Models.Cartao.BuscarTodos();
        }
    }
}