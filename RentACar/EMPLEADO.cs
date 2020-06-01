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
    
    public partial class EMPLEADO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EMPLEADO()
        {
            this.INSPECCION = new HashSet<INSPECCION>();
            this.RENTA = new HashSet<RENTA>();
        }
    
        public int ID { get; set; }
        public string NOMBRES { get; set; }
        public string APELLIDOS { get; set; }
        public Nullable<int> ID_TANDA { get; set; }
        public decimal PORCIENTO_COMISION { get; set; }
        public System.DateTime FECHA_INGRESO { get; set; }
        public System.DateTime FECHA_CREACION { get; set; }
        public Nullable<bool> ESTADO { get; set; }
        public string CLAVE { get; set; }
        public Nullable<int> ID_TIPO_EMPLEADO { get; set; }
    
        public virtual TANDA TANDA { get; set; }
        public virtual TIPO_EMPLEADO TIPO_EMPLEADO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSPECCION> INSPECCION { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RENTA> RENTA { get; set; }
    }
}
