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
    
    public partial class entradasaida
    {
        public int IDENTRADASAIDA { get; set; }
        public int CARROS_IDCARRO { get; set; }
        public Nullable<System.TimeSpan> HORAENTRADA { get; set; }
        public Nullable<System.TimeSpan> HORASAIDA { get; set; }
    
        public virtual carros carros { get; set; }
    }
}
