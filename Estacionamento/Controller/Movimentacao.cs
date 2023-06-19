namespace Controller
{
    public class Movimentacao {
        public static Model.Movimentacao CriarMovimentacao(
            string estacionamentoId,
            string dataEntrada,
            string dataSaida
        )
        {
            return Model.Movimentacao.CriarMovimentacao(
                int.Parse(estacionamentoId),
                DateTime.Parse(dataEntrada),
                DateTime.Parse(dataSaida)
            );
        }

        public static Model.Movimentacao AlterarMovimentacao(
            string id,
            string estacionamentoId,
            string dataEntrada,
            string dataSaida
        )
        {
            return Model.Movimentacao.AlterarMovimentacao(
                int.Parse(id),
                int.Parse(estacionamentoId),
                DateTime.Parse(dataEntrada),
                DateTime.Parse(dataSaida)
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