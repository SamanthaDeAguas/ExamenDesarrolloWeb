//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Pagos
    {
        public int id_pago { get; set; }
        public Nullable<int> id_orden { get; set; }
        public Nullable<System.DateTime> fecha_pago { get; set; }
        public decimal monto { get; set; }
        public string metodo_pago { get; set; }
        public string estado { get; set; }
    
        public virtual Ordenes Ordenes { get; set; }
    }
}
