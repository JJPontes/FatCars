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
    
    public partial class telefonecliente
    {
        public int IDTELEFONE { get; set; }
        public int CLIENTE_IDCLIENTE { get; set; }
        public string TIPO { get; set; }
        public string NUMTELEFONE { get; set; }
    
        public virtual cliente cliente { get; set; }
    }
}
