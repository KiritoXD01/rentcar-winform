﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RentACar
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DBEntities : DbContext
    {
        public DBEntities()
            : base("name=DBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<COMBUSTIBLE_VEHICULO> COMBUSTIBLE_VEHICULO { get; set; }
        public virtual DbSet<MARCA_VEHICULO> MARCA_VEHICULO { get; set; }
        public virtual DbSet<MODELO_VEHICULO> MODELO_VEHICULO { get; set; }
        public virtual DbSet<TIPO_VEHICULO> TIPO_VEHICULO { get; set; }
        public virtual DbSet<VEHICULO> VEHICULO { get; set; }
        public virtual DbSet<TIPO_CLIENTE> TIPO_CLIENTE { get; set; }
        public virtual DbSet<CLIENTE> CLIENTE { get; set; }
    }
}
