using MySql.Data.MySqlClient;

namespace Models
  {
  public class Cartao
    {
        public int Id { get; set; }
        public string Codigo { get; set; }

        public Cartao(string codigo)
        {
            Codigo = codigo;
        }


        public Cartao()
        {
        }

        public override string ToString()
        {
            return $"Id: {Id}, Codigo: {Codigo}";
        }

        public override bool Equals(object obj)
        {
            Cartao cartao = (Cartao)obj;
            return Id == cartao.Id;
        }

        public static Models.Cartao CriarCartao(
            int id,
            string codigo
        ) {
            return new Models.Cartao(
                codigo
            );
        }
        public static Models.Cartao AlterarCartao(
            int id,
            string codigo
        )
        {
            Cartao cartao = BuscarCartao(
                id
            );

            cartao.Codigo = codigo;

            Repository.Context context = new Repository.Context();
            context.Cartoes.Update(cartao);
            context.SaveChanges();

            return cartao;
        }

        public static Cartao ExcluirCartao(
            int id
        )
        {
            Cartao cartao = BuscarCartao(
                id
            );

            Repository.Context context = new Repository.Context();
            context.Cartoes.Remove(cartao);
            context.SaveChanges();

            return cartao;
        }

        public static Cartao BuscarCartao(
            int id
        )
        {
            Repository.Context context = new Repository.Context();
            return (
                from a in context.Cartoes
                where a.Id == id
                select a
            ).First();
        }

        //public static IEnumerable<Cartao> BuscarTodos()
        //{
        //    Repository.Context context = new Repository.Context();
        //    return (
        //        from a in context.Cartoes
        //        select a
        //    );
        //}

        public static List<Cartao> BuscarTodos()
        {
            List<Cartao> cartoes = new List<Cartao>();

            string connectionString = "Server=localhost;User Id=root;Database=estacionamento;";
            string query = "SELECT * FROM Cartao";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Cartao cartao = new Cartao
                            {
                                Id = reader.GetInt32("id"),
                                Codigo = reader.GetString("codigo"),
                            };

                            cartoes.Add(cartao);
                        }
                    }
                }
            }

        return cartoes;
        }
    }
}