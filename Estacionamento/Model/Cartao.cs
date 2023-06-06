 namespace Model
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

        public static Model.Cartao CriarCartao(
            string codigo
        ) {
            return new Model.Cartao(
                codigo
            );
        }
        public static Model.Cartao AlterarCartao(
            int id,
            string codigo
        )
        {
            Cartao cartao = BuscarCartao(
                id
            );

            cartao.Codigo = codigo;

            Repository.Context context = new Repository.Context();
            context.Cartaos.Update(cartao);
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
            context.Cartaos.Remove(cartao);
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

        public static IEnumerable<Cartao> BuscarTodos()
        {
            Repository.Context context = new Repository.Context();
            return (
                from a in context.Cartoes
                select a
            );
        }
    }
}