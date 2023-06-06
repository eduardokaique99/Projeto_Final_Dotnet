namespace Model
  {
  public class Turno
    {
        public int Id {get ; set;}
        public string Nome {get; set;}
        private int CPF {get; set;}
        public int PIS {get; set;}

        public Turno(string Nome, int CPF, int PIS)
        {
            Nome = nome;
            CPF = cpf;
            PIS = pis;
        }

        public Turno()
        {
        }

        public override string ToString()
        {
            return $"Id: {Id}, Nome: {Nome}, Pis: {PIS}";
        }

        public override bool Equals (object obj)
        {
            Turno turno = (Turno)obj;
            return Id == turno.Id;
        }

        public static Model.Turno CriarTurno(
            string nome,
            int CPF,
            int PIS
        ){
            return new Model.Turno(
                nome,
                CPF,
                PIS
            );
        }

        public static Model.Turno AlterarTurno(
            int id,
            string nome,
            int CPF,
            int PIS
        )
        {
            Turno turno = BuscarTurno(
                id
            );

            turno.Nome = nome;

            Repository.Context context = new Repository.Context();
            context.Turnos.Update(turno);
            contexto.SaveChanges();

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

        public static IEnumerable<Turno> BuscarTodos()
        {
            Repository.Context context = new Repository.Context();
            return (
                from a in context.Turnos
                select a
            );
        } 
    }
}