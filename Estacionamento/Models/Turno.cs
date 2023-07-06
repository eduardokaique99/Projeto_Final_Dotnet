using MySql.Data.MySqlClient;

namespace Models
  {
  public class Turno
    {
        public int Id {get ; set;}
        public string Periodo {get; set;}
        private int Escala {get; set;}
        public int IdEstacionamento {get; set;}

        public Turno(int id, string periodo, int escala, int idEstacionamento)
        {   
            Periodo = periodo;
            Escala = escala;
            IdEstacionamento = idEstacionamento;
        }

        public Turno()
        {
        }

        public override string ToString()
        {
            return $"Id: {Id}, Período: {Periodo}, Escala: {Escala}, IdEstacionamento: {IdEstacionamento}";
        }

        public override bool Equals (object obj)
        {
            Turno turno = (Turno)obj;
            return Id == turno.Id;
        }

        public static Models.Turno CriarTurno(
            int id,
            string periodo,
            int escala,
            int idEstacionamento
        ){
            return new Models.Turno(
                id,
                periodo,
                escala,
                idEstacionamento
            );
        }

        public static Models.Turno AlterarTurno(
            int id,
            string periodo,
            int escala,
            int idEstacionamento
        )
        {
            Turno turno = BuscarTurno(
                id
            );

            turno.Periodo = periodo;
            turno.Escala = escala;

            Repository.Context context = new Repository.Context();
            context.Turnos.Update(turno);
            context.SaveChanges();

            return turno;
        }

        public static Turno ExcluirTurno(
            int id
        )
        {
            Turno turno = BuscarTurno(
                id
            );

            Repository.Context context = new Repository.Context();
            context.Turnos.Remove(turno);
            context.SaveChanges();

            return turno;
        }

        public static Turno BuscarTurno(
            int id
        )
        {
            Repository.Context context = new Repository.Context();
            return (
                from a in context.Turnos
                where a.Id == id
                select a
            ).First();
        }

        //public static IEnumerable<Turno> BuscarTodos()
        //{
        //    Repository.Context context = new Repository.Context();
        //    return (
        //        from a in context.Turnos
        //        select a
        //    );
        //}

        public static List<Turno> BuscarTodos()
        {
            List<Turno> turnos = new List<Turno>();

            string connectionString = "Server=localhost;User Id=root;Database=estacionamento;";
            string query = "SELECT * FROM Turno";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Turno turno = new Turno
                            {
                                Id = reader.GetInt32("id"),
                                Periodo = reader.GetString("periodo"),
                                Escala = reader.GetInt32("escala"),
                                IdEstacionamento = reader.GetInt32("idestacionamento"),
                            };

                            turnos.Add(turno);
                        }
                    }
                }
            }

        return turnos;
        } 
    }
}