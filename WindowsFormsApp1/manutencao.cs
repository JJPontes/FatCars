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
    
    public partial class manutencao
    {
        public manutencao()
        {
            this.carros = new HashSet<carros>();
            this.manutencaopeca = new HashSet<manutencaopeca>();
        }
    
        public int IDMANUTENCAO { get; set; }
        public string DESCRICAO { get; set; }
        public decimal VALORMANUTENCAO { get; set; }
    
        public virtual ICollection<carros> carros { get; set; }
        public virtual ICollection<manutencaopeca> manutencaopeca { get; set; }
    }
}
