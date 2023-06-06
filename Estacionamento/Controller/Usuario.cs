namespace Controller
{
    public class Usuario {
        public static Model.Usuario CriarUsuario(
            string nome
        )
        {
            return Model.Usuario.CriarUsuario(
                nome
            );
        }

        public static Model.Usuario AlterarUsuario(
            string id,
            string nome
        )
        {
            return Model.Usuario.AlterarUsuario(
                int.Parse(id),
                nome
            );
        }

        public static Model.Usuario ExcluirUsuario(
            string id
        )
        {
            return Model.Usuario.ExcluirUsuario(
                int.Parse(id)
            );
        }

        public static Model.Usuario BuscarUsuario(
            string id
        ) {
            return Model.Usuario.BuscarUsuario(
                int.Parse(id)
            );
        }

        public static IEnumerable<Model.Usuario> BuscarUsuarios()
        {
            return Model.Usuario.BuscarTodos();
        }
    }
}