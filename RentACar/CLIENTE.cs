//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class CLIENTE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CLIENTE()
        {
            this.INSPECCION = new HashSet<INSPECCION>();
            this.RENTA = new HashSet<RENTA>();
        }
    
        public int ID { get; set; }
        public string NOMBRES { get; set; }
        public string APELLIDOS { get; set; }
        public string CEDULA { get; set; }
        public string EMAIL { get; set; }
        public string TELEFONO { get; set; }
        public string TARJETA_CREDITO { get; set; }
        public decimal LIMITE_CREDITO { get; set; }
        public Nullable<int> ID_TIPO_CLIENTE { get; set; }
        public Nullable<bool> ESTADO { get; set; }
        public System.DateTime FECHA_CREACION { get; set; }
    
        public virtual TIPO_CLIENTE TIPO_CLIENTE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSPECCION> INSPECCION { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RENTA> RENTA { get; set; }
    }
}
