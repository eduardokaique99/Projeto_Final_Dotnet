namespace Controllers
{
    public class Usuario {
        public static Models.Usuario CriarUsuario(
            string nome,
            string cpf,
            string pis,
            string permissao
        )
        {
            return Models.Usuario.CriarUsuario(
                nome,
                int.Parse(cpf),
                int.Parse(pis),
                permissao
            );
        }

        public static Models.Usuario AlterarUsuario(
            string id,
            string nome,
            string cpf,
            string pis,
            string permissao
        )
        {
            return Models.Usuario.AlterarUsuario(
                int.Parse(id),
                nome,
                int.Parse(cpf),
                int.Parse(pis),
                permissao
            );
        }

        public static Models.Usuario ExcluirUsuario(
            string id
        )
        {
            return Models.Usuario.ExcluirUsuario(
                int.Parse(id)
            );
        }

        public static Models.Usuario BuscarUsuario(
            string id
        ) {
            return Models.Usuario.BuscarUsuario(
                int.Parse(id)
            );
        }

        public static IEnumerable<Models.Usuario> BuscarUsuarios()
        {
            return Models.Usuario.BuscarTodos();
        }
    }
}