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
            string id,
            string descricao
        )
        {
            return Models.TipoVeiculo.AlterarTipoVeiculo(
                int.Parse(id),
                descricao
            );
        }

        public static Models.TipoVeiculo ExcluirTipoVeiculo(
            string id
        )
        {
            return Models.TipoVeiculo.ExcluirTipoVeiculo(
                int.Parse(id)
            );
        }

        public static Models.TipoVeiculo BuscarTipoVeiculo(
            string id
        ) {
            return Models.TipoVeiculo.BuscarTipoVeiculo(
                int.Parse(id)
            );
        }

        public static IEnumerable<Models.TipoVeiculo> BuscarTipoVeiculos()
        {
            return Models.TipoVeiculo.BuscarTodos();
        }
    }
}