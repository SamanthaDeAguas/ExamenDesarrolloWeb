﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExamenBack.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TiendaRJEntities : DbContext
    {
        public TiendaRJEntities()
            : base("name=TiendaRJEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<DetallesOrden> DetallesOrden { get; set; }
        public virtual DbSet<Ordenes> Ordenes { get; set; }
        public virtual DbSet<Pagos> Pagos { get; set; }
        public virtual DbSet<Relojes> Relojes { get; set; }
    }
}
