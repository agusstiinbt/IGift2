﻿using Domain.Entities;

namespace Application.Filtros.Pedidos
{
    public class PeticionesFilter : Specification<Peticiones>
    {
        public PeticionesFilter(string filtroBusqueda)
        {
            /*AddInclude(a => a.Categoria);*//* Esto se usa para evitar LazyLoading y hacer un EagleLoading*/
            if (!string.IsNullOrEmpty(filtroBusqueda))
            {
                Criteria = p => (p.Descripcion != null && p.Categoria != null) && (p.Descripcion.Contains(filtroBusqueda) || p.Categoria.Contains(filtroBusqueda));
            }
        }
    }
}
