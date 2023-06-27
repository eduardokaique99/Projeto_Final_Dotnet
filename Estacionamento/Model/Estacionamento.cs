 namespace Model
  {
  public class Estacionamento
    {
        public int Id { get; set; }
        public int QtdVagas { get; set; }


        public Estacionamento(int qtdVagas)
        {
            QtdVagas = qtdVagas;
        }

        public Estacionamento()
        {
        }

        public override string ToString()
        {
            return $"Id: {Id}, Codigo: {QtdVagas}";
        }

        public override bool Equals(object obj)
        {
            Estacionamento estacionamento = (Estacionamento)obj;
            return Id == estacionamento.Id;
        }

        public static Model.Estacionamento CriarEstacionamento(
            int qtdVagas
        ) {
            return new Model.Estacionamento(
                qtdVagas
            );
        }
        public static Model.Estacionamento AlterarEstacionamento(
            int id,
            int qtdVagas
        )
        {
            Estacionamento estacionamento = BuscarEstacionamento(
                id
            );

            estacionamento.QtdVagas = qtdVagas;

            Repository.Context context = new Repository.Context();
           
            context.SaveChanges();

            return estacionamento;
        }

        public static Estacionamento ExcluirEstacionamento(
            int id
        )
        {
            Estacionamento estacionamento = BuscarEstacionamento(
                id
            );

            Repository.Context context = new Repository.Context();

            context.SaveChanges();

            return estacionamento;
        }

        public static Estacionamento BuscarEstacionamento(
            int id
        )
        {
            Repository.Context context = new Repository.Context();
            return (
                from a in context.Estacionamentos
                where a.Id == id
                select a
            ).First();
        }

        public static IEnumerable<Estacionamento> BuscarTodos()
        {
            Repository.Context context = new Repository.Context();
            return (
                from a in context.Estacionamentos
                select a
            );
        }
    }
}