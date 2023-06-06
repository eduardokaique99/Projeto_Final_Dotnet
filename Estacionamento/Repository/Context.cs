using Microsoft.EntityFrameworkCore;
using Model;

namespace Repository
{
    public class Context : DbContext {
        public DbSet<Cartao> Cartoes { get; set; }
        public DbSet<Estacionamento> Estacionamentos { get; set; }
        public DbSet<Movimentacao> Movimentacoes { get; set; }
        public DbSet<TipoVeiculo> TipoVeiculos { get; set; }
        public DbSet<Turno> Turnos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Veiculo> Veiculos { get; set; }



        private const string _CONNECTION = "Server=localhost;User Id=root;Database=estacionamento;";

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder
        ) {
            optionsBuilder.UseMySql(
                _CONNECTION,
                MySqlServerVersion.AutoDetect(_CONNECTION)
            );
        }
    }
}