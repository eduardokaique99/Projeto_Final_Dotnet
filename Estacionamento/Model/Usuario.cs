  namespace Model
  {
  public class Usuario
    {
        public int id;  // o id tem como colocar automático, vamos pesquisar sobre
        public string nome;
        private int cpf;
        public int pis;

        public Usuario(int id, string nome, int cpf, int pis)
        {
            this.id = id;
            this.nome = nome;
            this.cpf = cpf;
            this.pis = pis;
        }

        public static void cadastrarUsuario(Usuario usuario)
        {
            usuarios.Add(usuario);
        }

        public static void listarUsuario()
        {
            foreach(Usuario usuario in usuarios)
            {
                Console.WriteLine("Id: " + id.usuario + "Nome: " + nome.usuario);
            }
        }

        public static void alterarUsuario(Usuario usuario)
        {
            int index = usuarios.FindIndex(p => p.id == usuario.id);
            if (index != -1)
            {
                usuarios[index] = usuario;
            }
        }
    }
}