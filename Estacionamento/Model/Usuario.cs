  namespace Model
  {
  public class Usuario
    {
        public int Id {get ; set;}
        public string Nome {get; set;}
        private int CPF {get; set;}
        public int PIS {get; set;}

        public Usuario(string Nome, int CPF, int PIS)
        {
            Nome = nome;
            CPF = cpf;
            PIS = pis;
        }

        public Usuario()
        {
        }

        public override string ToString()
        {
            return $"Id: {Id}, Nome: {Nome}, Pis: {PIS}";
        }

        public override bool Equals (object obj)
        {
            Usuario usuario = (Usuario)obj;
            return Id == usuario.Id;
        }

        public static Model.Usuario CriarUsuario(
            string nome,
            int CPF,
            int PIS
        ){
            return new Model.Usuario(
                nome,
                CPF,
                PIS
            );
        }

        public static Model.Usuario AlterarUsuario(
            int id,
            string nome,
            int CPF,
            int PIS
        )
        {
            Usuario usuario = BuscarUsuario(
                id
            );

            usuario.Nome = nome;

            Repository.Context context = new Repository.Context();
            context.Usuarios.Update(usuario);
            contexto.SaveChanges();

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