//------------------------------------------------------------------------------
// <auto-generated>
//    O código foi gerado a partir de um modelo.
//
//    Alterações manuais neste arquivo podem provocar comportamento inesperado no aplicativo.
//    Alterações manuais neste arquivo serão substituídas se o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    
    public partial class cor
    {
        public cor()
        {
            this.carros = new HashSet<carros>();
        }
    
        public int IDCOR { get; set; }
        public string COR1 { get; set; }
    
        public virtual ICollection<carros> carros { get; set; }
    }
}
