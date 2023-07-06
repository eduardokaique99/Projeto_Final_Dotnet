  namespace Models
  {
  public class Usuario
    {
        public int Id {get ; set;}
        public string Nome {get; set;}
        private int CPF {get; set;}
        public int PIS {get; set;}
        public string Permissao {get; set;}
        public string Senha {get; set;}


        public Usuario(int id, string nome, int cpf, int pis, string permissao, string senha)
        {
            Id = id;
            Nome = nome;
            CPF = cpf;
            PIS = pis;
            Permissao = permissao;
            Senha = senha;
        }

        public Usuario()
        {

        }

        public override string ToString()
        {
            return $"Id: {Id}, Nome: {Nome}, Pis: {PIS}, Permissão: {Permissao}";
        }

        public override bool Equals (object obj)
        {
            Usuario usuario = (Usuario)obj;
            return Id == usuario.Id;
        }

        public static Models.Usuario CriarUsuario(
            int id,
            string nome,
            int CPF,
            int PIS,
            string permissao,
            string senha
        ){
            return new Models.Usuario(
                id,
                nome,
                CPF,
                PIS,
                permissao,
                senha
            );
        }

        public static Models.Usuario AlterarUsuario(
            int id,
            string nome,
            int CPF,
            int PIS,
            string permissao,
            string senha
        )
        {
            Usuario usuario = BuscarUsuario(
                id
            );

            usuario.Nome = nome;

            Repository.Context context = new Repository.Context();
            context.Usuarios.Update(usuario);
            context.SaveChanges();

            return usuario;
        }

        public static Usuario ExcluirUsuario(
            int id
        )
        {
            Usuario usuario = BuscarUsuario(
                id
            );

            Repository.Context context = new Repository.Context();
            context.Usuarios.Remove(usuario);
            context.SaveChanges();

            return usuario;
        }

        public static Usuario BuscarUsuario(
            int id
        )
        {
            Repository.Context context = new Repository.Context();
            return (
                from a in context.Usuarios
                where a.Id == id
                select a
            ).First();
        }

        public static IEnumerable<Usuario> BuscarTodos()
        {
            Repository.Context context = new Repository.Context();
            return (
                from a in context.Usuarios
                select a
            );
        } 
    }
}