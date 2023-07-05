namespace Controllers
{
    public class TipoVeiculo {
        public static Models.TipoVeiculo CriarTipoVeiculo(
            int id,
            string descricao
        )
        {
            return Models.TipoVeiculo.CriarTipoVeiculo(
                descricao
            );
        }

        public static Models.TipoVeiculo AlterarTipoVeiculo(
            int id,
            string descricao
        )
        {
            return Models.TipoVeiculo.AlterarTipoVeiculo(
                id,
                descricao
            );
        }

        public static Models.TipoVeiculo ExcluirTipoVeiculo(
            int id
        )
        {
            return Models.TipoVeiculo.ExcluirTipoVeiculo(
                id
            );
        }

        public static Models.TipoVeiculo BuscarTipoVeiculo(
            int id
        ) {
            return Models.TipoVeiculo.BuscarTipoVeiculo(
                id
            );
        }

        public static IEnumerable<Models.TipoVeiculo> BuscarTipoVeiculos()
        {
            return Models.TipoVeiculo.BuscarTodos();
        }
    }
}