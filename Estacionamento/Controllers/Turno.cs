namespace Controllers
{
    public class Turno {
        public static Models.Turno CriarTurno(
            string periodo,
            string escala,
            string idEstacionamento
        )
        {
            return Models.Turno.CriarTurno(
                periodo,
                int.Parse(escala),
                int.Parse(idEstacionamento)
            );
        }

        public static Models.Turno AlterarTurno(
            string id,
            string periodo,
            string escala,
            string idEstacionamento
        )
        {
            return Models.Turno.AlterarTurno(
                int.Parse(id),
                periodo,
                int.Parse(escala),
                int.Parse(idEstacionamento)
            );
        }

        public static Models.Turno ExcluirTurno(
            string id
        )
        {
            return Models.Turno.ExcluirTurno(
                int.Parse(id)
            );
        }

        public static Models.Turno BuscarTurno(
            string id
        ) {
            return Models.Turno.BuscarTurno(
                int.Parse(id)
            );
        }

        public static IEnumerable<Models.Turno> BuscarTurnos()
        {
            return Models.Turno.BuscarTodos();
        }
    }
}