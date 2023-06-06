namespace Controller
{
    public class Estacionamento {
        public static Model.Estacionamento CriarEstacionamento(
            string nome
        )
        {
            return Model.Estacionamento.CriarEstacionamento(
                nome
            );
        }

        public static Model.Estacionamento AlterarEstacionamento(
            string id,
            string nome
        )
        {
            return Model.Estacionamento.AlterarEstacionamento(
                int.Parse(id),
                nome
            );
        }

        public static Model.Estacionamento ExcluirEstacionamento(
            string id
        )
        {
            return Model.Estacionamento.ExcluirEstacionamento(
                int.Parse(id)
            );
        }

        public static Model.Estacionamento BuscarEstacionamento(
            string id
        ) {
            return Model.Estacionamento.BuscarEstacionamento(
                int.Parse(id)
            );
        }

        public static IEnumerable<Model.Estacionamento> BuscarEstacionamentos()
        {
            return Model.Estacionamento.BuscarTodos();
        }
    }
}