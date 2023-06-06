namespace Controller
{
    public class Veiculo {
        public static Model.Veiculo CriarVeiculo(
            string nome
        )
        {
            return Model.Veiculo.CriarVeiculo(
                nome
            );
        }

        public static Model.Veiculo AlterarVeiculo(
            string id,
            string nome
        )
        {
            return Model.Veiculo.AlterarVeiculo(
                int.Parse(id),
                nome
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