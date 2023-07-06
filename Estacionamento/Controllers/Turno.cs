namespace Controllers
{
    public class Turno {
        public static Models.Turno CriarTurno(
            int id,
            string periodo,
            int escala,
            int idEstacionamento
        )
        {
            return Models.Turno.CriarTurno(
                id,
                periodo,
                escala,
                idEstacionamento
            );
        }

        public static Models.Turno AlterarTurno(
            int id,
            string periodo,
            int escala,
            int idEstacionamento
        )
        {
            return Models.Turno.AlterarTurno(
                id,
                periodo,
                escala,
                idEstacionamento
            );
        }

        public static Models.Turno ExcluirTurno(
            int id
        )
        {
            return Models.Turno.ExcluirTurno(
                id
            );
        }

        public static Models.Turno BuscarTurno(
            int id
        ) {
            return Models.Turno.BuscarTurno(
                id
            );
        }

        public static IEnumerable<Models.Turno> BuscarTurnos()
        {
            return Models.Turno.BuscarTodos();
        }
    }
}