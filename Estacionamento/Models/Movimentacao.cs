namespace Models
  {
  public class Movimentacao
    {
        public int Id { get; set; }
        public int EstacionamentoId { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime DataSaida { get; set; }
        public virtual Estacionamento Estacionamento { get; set; }


        public Movimentacao(int id, int estacionamentoId, DateTime dataEntrada, DateTime dataSaida)
        {
            Id = id;
            EstacionamentoId = estacionamentoId;
            DataEntrada = dataEntrada;
            DataSaida = dataSaida;
        }


        public Movimentacao()
        {
        }

        public override string ToString()
        {
            return $"Id: {Id}, Data de Entrada: {DataEntrada}, Data de Saida: {DataSaida}, IdEstacionamento: {EstacionamentoId}";
        }

        public override bool Equals(object obj)
        {
            Movimentacao movimentacao = (Movimentacao)obj;
            return Id == movimentacao.Id;
        }

        public static Models.Movimentacao CriarMovimentacao(
            int id, int estacionamentoId, DateTime dataEntrada, DateTime dataSaida
        ) {
            return new Models.Movimentacao(
                id,
                estacionamentoId, 
                dataEntrada, 
                dataSaida
            );
        }
        public static Models.Movimentacao AlterarMovimentacao(
            int id,
            int estacionamentoId, 
            DateTime dataEntrada, 
            DateTime dataSaida
        )
        {
            Movimentacao movimentacao = BuscarMovimentacao(
                id
            );

            movimentacao.EstacionamentoId = estacionamentoId;
            movimentacao.DataEntrada = dataEntrada;
            movimentacao.DataSaida = dataSaida;

            Repository.Context context = new Repository.Context();
            context.Movimentacoes.Update(movimentacao);
            context.SaveChanges();

            return movimentacao;
        }

        public static Movimentacao ExcluirMovimentacao(
            int id
        )
        {
            Movimentacao movimentacao = BuscarMovimentacao(
                id
            );

            Repository.Context context = new Repository.Context();
            context.Movimentacoes.Remove(movimentacao);
            context.SaveChanges();

            return movimentacao;
        }

        public static Movimentacao BuscarMovimentacao(
            int id
        )
        {
            Repository.Context context = new Repository.Context();
            return (
                from a in context.Movimentacoes
                where a.Id == id
                select a
            ).First();
        }

        public static IEnumerable<Movimentacao> BuscarTodos()
        {
            Repository.Context context = new Repository.Context();
            return (
                from a in context.Movimentacoes
                select a
            );
        }
    }
}