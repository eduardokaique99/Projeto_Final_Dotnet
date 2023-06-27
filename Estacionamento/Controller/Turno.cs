namespace Controller
{
    public class Turno {
        public static Model.Turno CriarTurno(
            string periodo,
            string escala,
            string idEstacionamento
        )
        {
            return Model.Turno.CriarTurno(
                periodo,
                int.Parse(escala),
                int.Parse(idEstacionamento)
            );
        }

        public static Model.Turno AlterarTurno(
            string id,
            string periodo,
            string escala,
            string idEstacionamento
        )
        {
            return Model.Turno.AlterarTurno(
                int.Parse(id),
                periodo,
                int.Parse(escala),
                int.Parse(idEstacionamento)
            );
        }

        public static Model.Turno ExcluirTurno(
            string id
        )
        {
            return Model.Turno.ExcluirTurno(
                int.Parse(id)
            );
        }

        public static Model.Turno BuscarTurno(
            string id
        ) {
            return Model.Turno.BuscarTurno(
                int.Parse(id)
            );
        }

        public static IEnumerable<Model.Turno> BuscarTurnos()
        {
            return Model.Turno.BuscarTodos();
        }
    }
}