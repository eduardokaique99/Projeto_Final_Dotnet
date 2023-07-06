

using MySql.Data.MySqlClient;

namespace Models
  {
  public class Veiculo
    {
        public int Id {get ; set;}
        public string Placa {get; set;}
        public int IdMovimentacao {get; set;}
        public int IdTipo {get; set;}
        public int IdCartao {get; set;}

        public Veiculo(int id, string placa, int idMovimentacao, int idTipo, int idCartao)
        {
            Placa = placa;
            IdMovimentacao = idMovimentacao;
            IdTipo = idTipo;
            IdCartao = idCartao;
        }

        public Veiculo()
        {
        }

        public override string ToString()
        {
            return $"Id: {Id}, Placa: {Placa}, Id da Movimentação: {IdMovimentacao}, Id do Tipo: {IdTipo}, Id do Cartão: {IdCartao}";
        }

        public override bool Equals (object obj)
        {
            Veiculo veiculo = (Veiculo)obj;
            return Id == veiculo.Id;
        }

        public static Models.Veiculo CriarVeiculo(
            int id,
            string placa,
            int idMovimentacao,
            int idTipo,
            int idCartao
        ){
            return new Models.Veiculo(
                id,
                placa,
                idMovimentacao,
                idTipo,
                idCartao
            );
        }

        public static Models.Veiculo AlterarVeiculo(
            int id,
            string placa,
            int idMovimentacao,
            int idTipo,
            int idCartao
        )
        {
            Veiculo veiculo = BuscarVeiculo(
                id
            );

            veiculo.Placa = placa;

            Repository.Context context = new Repository.Context();
            context.Veiculos.Update(veiculo);
            context.SaveChanges();

            return veiculo;
        }

        public static Veiculo ExcluirVeiculo(
            int id
        )
        {
            Veiculo veiculo = BuscarVeiculo(
                id
            );

            Repository.Context context = new Repository.Context();
            context.Veiculos.Remove(veiculo);
            context.SaveChanges();

            return veiculo;
        }

        public static Veiculo BuscarVeiculo(
            int id
        )
        {
            Repository.Context context = new Repository.Context();
            return (
                from a in context.Veiculos
                where a.Id == id
                select a
            ).First();
        }

        //public static IEnumerable<Veiculo> BuscarTodos()
        //{
        //    Repository.Context context = new Repository.Context();
        //    return (
        //        from a in context.Veiculos
        //        select a
        //    );
        //}

        public static List<Veiculo> BuscarTodos()
        {
            List<Veiculo> veiculos = new List<Veiculo>();

            string connectionString = "Server=localhost;User Id=root;Database=estacionamento;";
            string query = "SELECT * FROM Veiculo";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Veiculo veiculo = new Veiculo
                            {
                                Id = reader.GetInt32("id"),
                                Placa = reader.GetString("placa"),
                                IdMovimentacao = reader.GetInt32("id"),
                                IdTipo = reader.GetInt32("id"),
                                IdCartao = reader.GetInt32("id"),
                            };

                            veiculos.Add(veiculo);
                        }
                    }
                }
            }

        return veiculos;
        }
         
    }
}