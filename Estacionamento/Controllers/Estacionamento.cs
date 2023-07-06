namespace Controllers
{
    public class Estacionamento {
        public static Models.Estacionamento CriarEstacionamento(
            int id,
            string qtdVagas
        )
        {
            return Models.Estacionamento.CriarEstacionamento(
                id,
                int.Parse(qtdVagas)
            );
        }

        public static Models.Estacionamento AlterarEstacionamento(
            string id,
            string qtdVagas
        )
        {
            return Models.Estacionamento.AlterarEstacionamento(
                int.Parse(id),
                int.Parse(qtdVagas)
            );
        }

        public static Models.Estacionamento ExcluirEstacionamento(
            string id
        )
        {
            return Models.Estacionamento.ExcluirEstacionamento(
                int.Parse(id)
            );
        }

        public static Models.Estacionamento BuscarEstacionamento(
            string id
        ) {
            return Models.Estacionamento.BuscarEstacionamento(
                int.Parse(id)
            );
        }

        //public static IEnumerable<Models.Estacionamento> BuscarEstacionamentos()
        //{
        //    return Models.Estacionamento.BuscarTodos();
        //}
    }
}