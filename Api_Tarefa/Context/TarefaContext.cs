using Api_Tarefa.Model;
using Microsoft.EntityFrameworkCore;

namespace Api_Tarefa.Context
{
    public class TarefaContext : DbContext
    {
        public TarefaContext(DbContextOptions<TarefaContext> options) : base(options)
        {

        }

        public DbSet<TarefaItem> Tarefas { get; set; }
    }
}
