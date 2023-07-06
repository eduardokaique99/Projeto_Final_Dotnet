using MySql.Data.MySqlClient;

namespace Models
  {
  public class TipoVeiculo
    {
        public int Id {get; set; }
        public string Descricao {get; set; }

        public TipoVeiculo(int id, string descricao)
        {
            Descricao = descricao;
        }


        public TipoVeiculo()
        {
        }

        public override string ToString()
        {
            return $"Id: {Id}, Descricao: {Descricao}";
        }

        public override bool Equals(object obj)
        {
            TipoVeiculo tipoveiculo = (TipoVeiculo)obj;
            return Id == tipoveiculo.Id;
        }

        public static Models.TipoVeiculo CriarTipoVeiculo(
            int id,
            string descricao
        ) {
            return new Models.TipoVeiculo(
                id,
                descricao
            );
        }
        public static Models.TipoVeiculo AlterarTipoVeiculo(
            int id,
            string descricao
        )
        {
            TipoVeiculo tipoveiculo = BuscarTipoVeiculo(
                id
            );

            tipoveiculo.Descricao = descricao;

            Repository.Context context = new Repository.Context();
            context.TipoVeiculos.Update(tipoveiculo);
            context.SaveChanges();

            return tipoveiculo;
        }

        public static TipoVeiculo ExcluirTipoVeiculo(
            int id
        )
        {
            TipoVeiculo tipoveiculo = BuscarTipoVeiculo(
                id
            );

            Repository.Context context = new Repository.Context();
            context.TipoVeiculos.Remove(tipoveiculo);
            context.SaveChanges();

            return tipoveiculo;
        }

        public static TipoVeiculo BuscarTipoVeiculo(
            int id
        )
        {
            Repository.Context context = new Repository.Context();
            return (
                from a in context.TipoVeiculos
                where a.Id == id
                select a
            ).First();
        }

        //public static IEnumerable<TipoVeiculo> BuscarTodos()
        //{
        //    Repository.Context context = new Repository.Context();
        //    return (
        //        from a in context.TipoVeiculos
        //        select a
        //    );
        //}

        public static List<TipoVeiculo> BuscarTodos()
        {
            List<TipoVeiculo> tipoVeiculos = new List<TipoVeiculo>();

            string connectionString = "Server=localhost;User Id=root;Database=estacionamento;";
            string query = "SELECT * FROM TipoVeiculo";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            TipoVeiculo tipoVeiculo = new TipoVeiculo
                            {
                                Id = reader.GetInt32("id"),
                                Descricao = reader.GetString("descricao"),
                            };

                            tipoVeiculos.Add(tipoVeiculo);
                        }
                    }
                }
            }

        return tipoVeiculos;
        }
    }
}