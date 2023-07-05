namespace Controllers
{
    public class Movimentacao {
        public static Models.Movimentacao CriarMovimentacao(
            int id,
            int estacionamentoId,
            string dataEntrada,
            string dataSaida
        )
        {
            return Models.Movimentacao.CriarMovimentacao(
                id,
                estacionamentoId,
                DateTime.Parse(dataEntrada),
                DateTime.Parse(dataSaida)
            );
        }

        public static Models.Movimentacao AlterarMovimentacao(
            int id,
            int estacionamentoId,
            string dataEntrada,
            string dataSaida
        )
        {
            return Models.Movimentacao.AlterarMovimentacao(
                id,
                estacionamentoId,
                DateTime.Parse(dataEntrada),
                DateTime.Parse(dataSaida)
            );
        }

        public static Models.Movimentacao ExcluirMovimentacao(
            int id
        )
        {
            return Models.Movimentacao.ExcluirMovimentacao(
                id
            );
        }

        public static Models.Movimentacao BuscarMovimentacao(
            int id
        ) {
            return Models.Movimentacao.BuscarMovimentacao(
                id
            );
        }

        public static IEnumerable<Models.Movimentacao> BuscarMovimentacaos()
        {
            return Models.Movimentacao.BuscarTodos();
        }
    }
}