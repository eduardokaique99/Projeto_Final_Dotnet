namespace Controllers
{
    public class Cartao {
        public static Models.Cartao CriarCartao(
            int id,
            string codigo
        )
        {
            return Models.Cartao.CriarCartao(
                id,
                codigo
            );
        }

        public static Models.Cartao AlterarCartao(
            int id,
            string Codigo
        )
        {
            return Models.Cartao.AlterarCartao(
                id,
                Codigo
            );
        }

        public static Models.Cartao ExcluirCartao(
            int id
        )
        {
            return Models.Cartao.ExcluirCartao(
                id
            );
        }

        public static Models.Cartao BuscarCartao(
            int id
        ) {
            return Models.Cartao.BuscarCartao(
                id
            );
        }

        public static IEnumerable<Models.Cartao> BuscarCartaos()
        {
            return Models.Cartao.BuscarTodos();
        }
    }
}