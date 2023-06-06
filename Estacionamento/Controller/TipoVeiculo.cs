namespace Controller
{
    public class TipoVeiculo {
        public static Model.TipoVeiculo CriarTipoVeiculo(
            string nome
        )
        {
            return Model.TipoVeiculo.CriarTipoVeiculo(
                nome
            );
        }

        public static Model.TipoVeiculo AlterarTipoVeiculo(
            string id,
            string nome
        )
        {
            return Model.TipoVeiculo.AlterarTipoVeiculo(
                int.Parse(id),
                nome
            );
        }

        public static Model.TipoVeiculo ExcluirTipoVeiculo(
            string id
        )
        {
            return Model.TipoVeiculo.ExcluirTipoVeiculo(
                int.Parse(id)
            );
        }

        public static Model.TipoVeiculo BuscarTipoVeiculo(
            string id
        ) {
            return Model.TipoVeiculo.BuscarTipoVeiculo(
                int.Parse(id)
            );
        }

        public static IEnumerable<Model.TipoVeiculo> BuscarTipoVeiculos()
        {
            return Model.TipoVeiculo.BuscarTodos();
        }
    }
}