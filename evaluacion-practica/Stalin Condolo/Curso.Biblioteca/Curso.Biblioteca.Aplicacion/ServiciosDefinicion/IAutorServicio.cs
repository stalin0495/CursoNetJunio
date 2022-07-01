using Curso.Biblioteca.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso.Biblioteca.Aplicacion.ServiciosDefinicion
{
    public interface IAutorServicio
    {
        Task<ICollection<Autor>> GetAllAsync();
        Task CreateAsync(Autor entity);
        Task UpdateAsync(Autor entity);
        Task DeleteAsync(Autor entity);
    }
}
