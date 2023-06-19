namespace Controller
{
    public class Veiculo {
        public static Model.Veiculo CriarVeiculo(
            string placa,
            string idmovimentacao,
            string idtipo,
            string idcartao
        )
        {
            return Model.Veiculo.CriarVeiculo(
                placa,
                int.Parse(idmovimentacao),
                int.Parse(idtipo),
                int.Parse(idcartao)
            );
        }

        public static Model.Veiculo AlterarVeiculo(
            string id,
            string placa,
            string idmovimentacao,
            string idtipo,
            string idcartao
        )
        {
            return Model.Veiculo.AlterarVeiculo(
                int.Parse(id),
                placa,
                int.Parse(idmovimentacao),
                int.Parse(idtipo),
                int.Parse(idcartao)
            );
        }

        public static Model.Veiculo ExcluirVeiculo(
            string id
        )
        {
            return Model.Veiculo.ExcluirVeiculo(
                int.Parse(id)
            );
        }

        public static Model.Veiculo BuscarVeiculo(
            string id
        ) {
            return Model.Veiculo.BuscarVeiculo(
                int.Parse(id)
            );
        }

        public static IEnumerable<Model.Veiculo> BuscarVeiculos()
        {
            return Model.Veiculo.BuscarTodos();
        }
    }
}