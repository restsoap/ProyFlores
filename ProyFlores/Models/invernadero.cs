//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyFlores.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class invernadero
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public invernadero()
        {
            this.probloque = new HashSet<probloque>();
            this.planillaproduccion = new HashSet<planillaproduccion>();
        }
    
        public int idinvernadero { get; set; }
        public int idfinca { get; set; }
        public Nullable<int> numeroinvernadero { get; set; }
    
        public virtual finca finca { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<probloque> probloque { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<planillaproduccion> planillaproduccion { get; set; }
    }
}