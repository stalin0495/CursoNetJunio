using Curso.Biblioteca.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso.Biblioteca.Aplicacion.ServiciosDefinicion
{
    public interface IEditorialServicio
    {
        Task<ICollection<Editorial>> GetAllAsync();
        Task CreateAsync(Editorial entity);
        Task UpdateAsync(Editorial entity);
        Task DeleteAsync(Editorial entity);
    }
}
