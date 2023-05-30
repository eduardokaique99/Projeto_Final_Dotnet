  namespace Model
  {
  public class TipoVeiculo
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        public TipoVeiculo(string descricao)
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

        public static Model.TipoVeiculo CriarTipoVeiculo(
            string descricao
        ) {
            return new Model.TipoVeiculo(
                descricao
            );
        }
        public static Model.TipoVeiculo AlterarTipoVeiculo(
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

        public static IEnumerable<TipoVeiculo> BuscarTodos()
        {
            Repository.Context context = new Repository.Context();
            return (
                from a in context.TipoVeiculos
                select a
            );
        }
    }
}