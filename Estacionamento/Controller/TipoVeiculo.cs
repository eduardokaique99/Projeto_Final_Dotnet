namespace Controller
{
    public class TipoVeiculo {
        public static Model.TipoVeiculo CriarTipoVeiculo(
            string descricao
        )
        {
            return Model.TipoVeiculo.CriarTipoVeiculo(
                descricao
            );
        }

        public static Model.TipoVeiculo AlterarTipoVeiculo(
            string id,
            string descricao
        )
        {
            return Model.TipoVeiculo.AlterarTipoVeiculo(
                int.Parse(id),
                descricao
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