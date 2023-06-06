namespace Controller
{
    public class Movimentacao {
        public static Model.Movimentacao CriarMovimentacao(
            string nome
        )
        {
            return Model.Movimentacao.CriarMovimentacao(
                nome
            );
        }

        public static Model.Movimentacao AlterarMovimentacao(
            string id,
            string nome
        )
        {
            return Model.Movimentacao.AlterarMovimentacao(
                int.Parse(id),
                nome
            );
        }

        public static Model.Movimentacao ExcluirMovimentacao(
            string id
        )
        {
            return Model.Movimentacao.ExcluirMovimentacao(
                int.Parse(id)
            );
        }

        public static Model.Movimentacao BuscarMovimentacao(
            string id
        ) {
            return Model.Movimentacao.BuscarMovimentacao(
                int.Parse(id)
            );
        }

        public static IEnumerable<Model.Movimentacao> BuscarMovimentacaos()
        {
            return Model.Movimentacao.BuscarTodos();
        }
    }
}