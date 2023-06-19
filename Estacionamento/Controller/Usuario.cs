namespace Controller
{
    public class Usuario {
        public static Model.Usuario CriarUsuario(
            string nome,
            string cpf,
            string pis,
            string permissao
        )
        {
            return Model.Usuario.CriarUsuario(
                nome,
                int.Parse(cpf),
                int.Parse(pis),
                permissao
            );
        }

        public static Model.Usuario AlterarUsuario(
            string nome,
            string cpf,
            string pis,
            string permissao
        )
        {
            return Model.Usuario.AlterarUsuario(
                int.Parse(id),
                nome,
                int.Parse(cpf),
                int.Parse(pis),
                permissao
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