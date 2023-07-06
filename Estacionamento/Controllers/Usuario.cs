namespace Controllers
{
    public class Usuario {
        public static Models.Usuario CriarUsuario(
            int id,
            string nome,
            int cpf,
            int pis,
            string permissao,
            string senha
        )
        {
            return Models.Usuario.CriarUsuario(
                id,
                nome,
                cpf,
                pis,
                permissao,
                senha
            );
        }


        public static void ListaUsuario()
        {
        List<Usuario> usuarios = new List<Usuario>();

        //foreach (string usuario in usuarios)
        //{
        //    Console.WriteLine(usuario);
        //}
        }


        public static Models.Usuario AlterarUsuario(
            int id,
            string nome,
            int cpf,
            int pis,
            string permissao,
            string senha
        )
        {
            return Models.Usuario.AlterarUsuario(
                id,
                nome,
                cpf,
                pis,
                permissao,
                senha
            );
        }

        public static Models.Usuario ExcluirUsuario(
            int id
        )
        {
            return Models.Usuario.ExcluirUsuario(
                id
            );
        }

        public static Models.Usuario BuscarUsuario(
            int id
        ) {
            return Models.Usuario.BuscarUsuario(
                id
            );
        }

        public static IEnumerable<Models.Usuario> BuscarUsuarios()
        {
            return Models.Usuario.BuscarTodos();
        }
    }
}