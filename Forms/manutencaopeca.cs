//------------------------------------------------------------------------------
// <auto-generated>
//    O código foi gerado a partir de um modelo.
//
//    Alterações manuais neste arquivo podem provocar comportamento inesperado no aplicativo.
//    Alterações manuais neste arquivo serão substituídas se o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Forms
{
    using System;
    using System.Collections.Generic;
    
    public partial class manutencaopeca
    {
        public int IDMANUTENCAOPECA { get; set; }
        public int PECAS_IDPECAS { get; set; }
        public int MANUTENCAO_IDMANUTENCAO { get; set; }
        public decimal VALOR { get; set; }
    
        public virtual manutencao manutencao { get; set; }
        public virtual pecas pecas { get; set; }
    }
}
