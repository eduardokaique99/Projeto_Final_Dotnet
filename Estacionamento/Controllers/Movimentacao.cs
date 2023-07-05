namespace Controllers
{
    public class Movimentacao {
        public static Models.Movimentacao CriarMovimentacao(
            string estacionamentoId,
            string dataEntrada,
            string dataSaida
        )
        {
            return Models.Movimentacao.CriarMovimentacao(
                int.Parse(estacionamentoId),
                DateTime.Parse(dataEntrada),
                DateTime.Parse(dataSaida)
            );
        }

        public static Models.Movimentacao AlterarMovimentacao(
            string id,
            string estacionamentoId,
            string dataEntrada,
            string dataSaida
        )
        {
            return Models.Movimentacao.AlterarMovimentacao(
                int.Parse(id),
                int.Parse(estacionamentoId),
                DateTime.Parse(dataEntrada),
                DateTime.Parse(dataSaida)
            );
        }

        public static Models.Movimentacao ExcluirMovimentacao(
            string id
        )
        {
            return Models.Movimentacao.ExcluirMovimentacao(
                int.Parse(id)
            );
        }

        public static Models.Movimentacao BuscarMovimentacao(
            string id
        ) {
            return Models.Movimentacao.BuscarMovimentacao(
                int.Parse(id)
            );
        }

        public static IEnumerable<Models.Movimentacao> BuscarMovimentacaos()
        {
            return Models.Movimentacao.BuscarTodos();
        }
    }
}