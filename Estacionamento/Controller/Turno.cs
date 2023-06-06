namespace Controller
{
    public class Turno {
        public static Model.Turno CriarTurno(
            string nome
        )
        {
            return Model.Turno.CriarTurno(
                nome
            );
        }

        public static Model.Turno AlterarTurno(
            string id,
            string nome
        )
        {
            return Model.Turno.AlterarTurno(
                int.Parse(id),
                nome
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