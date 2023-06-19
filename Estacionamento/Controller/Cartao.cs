namespace Controller
{
    public class Cartao {
        public static Model.Cartao CriarCartao(
            string Codigo
        )
        {
            return Model.Cartao.CriarCartao(
                Codigo
            );
        }

        public static Model.Cartao AlterarCartao(
            string id,
            string Codigo
        )
        {
            return Model.Cartao.AlterarCartao(
                int.Parse(id),
                Codigo
            );
        }

        public static Model.Cartao ExcluirCartao(
            string id
        )
        {
            return Model.Cartao.ExcluirCartao(
                int.Parse(id)
            );
        }

        public static Model.Cartao BuscarCartao(
            string id
        ) {
            return Model.Cartao.BuscarCartao(
                int.Parse(id)
            );
        }

        public static IEnumerable<Model.Cartao> BuscarCartaos()
        {
            return Model.Cartao.BuscarTodos();
        }
    }
}