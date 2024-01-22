using Microsoft.EntityFrameworkCore;
using GestorTareas_MVC.Models;
using GestorTareas_MVC.Servicios.Contrato;
using GestorTareas_MVC.Repos;

namespace GestorTareas_MVC.Servicios.Implementacion
{
    public class UsuarioService : IUsuarioService
    {

        private readonly GestorTareasContext _dbContext;

        public UsuarioService(GestorTareasContext dbContext) {
            _dbContext = dbContext;
        }
        public async Task<Usuario> GetUsuarios(string correo, string clave)
        {

            Usuario usuario_encontrado = await _dbContext.Usuarios.Where(u => u.Correo == correo && u.Clave == clave).FirstOrDefaultAsync();
            return usuario_encontrado;
        }

        public async Task<Usuario> SaveUsuario(Usuario modelo)
        {
            _dbContext.Usuarios.Add(modelo);
            await _dbContext.SaveChangesAsync();
            return modelo;
        }
    }
}
