using Microsoft.EntityFrameworkCore;
using GestorTareas_MVC.Models;

namespace GestorTareas_MVC.Servicios.Contrato
{
    public interface IUsuarioService
    {
        Task<Usuario> GetUsuarios(string correo, string clave);
        Task<Usuario> SaveUsuario(Usuario modelo);
    }
}
