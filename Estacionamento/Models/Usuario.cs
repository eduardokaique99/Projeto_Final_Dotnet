using MySql.Data.MySqlClient;  
  
  namespace Models
  {
  public class Usuario
    {
        public int Id {get ; set;}
        public string Nome {get; set;}
        public string CPF {get; set;}
        public string PIS {get; set;}
        public string Permissao {get; set;}
        public string Senha {get; set;}
        private static List<Usuario> usuarios = new List<Usuario>();


        public Usuario(int id, string nome, string cpf, string pis, string permissao, string senha)
        {
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
            string cpf,
            string pis,
            string permissao,
            string senha
        ){
            return new Models.Usuario(
                id,
                nome,
                cpf,
                pis,
                permissao,
                senha
            );
        }

        public static Models.Usuario AlterarUsuario(
            int id,
            string nome,
            string cpf,
            string pis,
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

        //public static IEnumerable<Usuario> BuscarTodos()
        //{
        //    Repository.Context context = new Repository.Context();
        //    return (
        //        from a in context.Usuarios
        //        select a
        //    );
        //}

        public static List<Usuario> BuscarTodos()
        {
            List<Usuario> usuarios = new List<Usuario>();

            string connectionString = "Server=localhost;User Id=root;Database=estacionamento;";
            string query = "SELECT * FROM Usuario";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Usuario usuario = new Usuario
                            {
                                Id = reader.GetInt32("id"),
                                Nome = reader.GetString("nome"),
                                CPF = reader.GetString("cpf"),
                                PIS = reader.GetString("pis"),
                                Permissao = reader.GetString("permissao"),
                            };

                            usuarios.Add(usuario);
                        }
                    }
                }
            }

        return usuarios;
        }

        public static bool Login(string nome, string senha)
        {
            string connectionString = "Server=localhost;User Id=root;Database=estacionamento;";
            string query = "SELECT COUNT(*) FROM Usuario WHERE Nome = @nome AND Senha = @senha";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nome", nome);
                    command.Parameters.AddWithValue("@senha", senha);

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    return count > 0;
                }
            }
        }
    }
}