namespace Controllers
{
    public class Veiculo {
        public static Models.Veiculo CriarVeiculo(
            int id,
            string placa,
            int idmovimentacao,
            int idtipo,
            int idcartao
        )
        {
            return Models.Veiculo.CriarVeiculo(
                id,
                placa,
                idmovimentacao,
                idtipo,
                idcartao
            );
        }

        public static Models.Veiculo AlterarVeiculo(
            int id,
            string placa,
            int idmovimentacao,
            int idtipo,
            int idcartao
        )
        {
            return Models.Veiculo.AlterarVeiculo(
                id,
                placa,
                idmovimentacao,
                idtipo,
                idcartao
            );
        }

        public static Models.Veiculo ExcluirVeiculo(
            int id
        )
        {
            return Models.Veiculo.ExcluirVeiculo(
                id
            );
        }

        public static Models.Veiculo BuscarVeiculo(
            int id
        ) {
            return Models.Veiculo.BuscarVeiculo(
                id
            );
        }

        public static IEnumerable<Models.Veiculo> BuscarVeiculos()
        {
            return Models.Veiculo.BuscarTodos();
        }
    }
}