
using ControleDeContatos.Data;
using ControleDeContatos.Repositorio;
using Microsoft.EntityFrameworkCore;

namespace ControleDeContatos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            
            builder.Services.AddDbContext<BancoContext> //Conectando da forma nova
                (options => options.UseSqlServer("Server=DESKTOP-I91URTC\\SQLEXPRESS;Database=DB_SistemaContatos;Trusted_Connection=True;Encrypt=False;"));
            builder.Services.AddScoped<IContatoRepositorio, ContatoRepositorio>(); //Configurando injeção para de Interface a repositorio

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}