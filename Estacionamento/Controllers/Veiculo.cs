namespace Controllers
{
    public class Veiculo {
        public static Models.Veiculo CriarVeiculo(
            string id,
            string placa,
            string idmovimentacao,
            string idtipo,
            string idcartao
        )
        {
            return Models.Veiculo.CriarVeiculo(
                int.Parse(id),
                placa,
                int.Parse(idmovimentacao),
                int.Parse(idtipo),
                int.Parse(idcartao)
            );
        }

        public static Models.Veiculo AlterarVeiculo(
            string id,
            string placa,
            string idmovimentacao,
            string idtipo,
            string idcartao
        )
        {
            return Models.Veiculo.AlterarVeiculo(
                int.Parse(id),
                placa,
                int.Parse(idmovimentacao),
                int.Parse(idtipo),
                int.Parse(idcartao)
            );
        }

        public static Models.Veiculo ExcluirVeiculo(
            string id
        )
        {
            return Models.Veiculo.ExcluirVeiculo(
                int.Parse(id)
            );
        }

        public static Models.Veiculo BuscarVeiculo(
            string id
        ) {
            return Models.Veiculo.BuscarVeiculo(
                int.Parse(id)
            );
        }

        public static IEnumerable<Models.Veiculo> BuscarVeiculos()
        {
            return Models.Veiculo.BuscarTodos();
        }
    }
}