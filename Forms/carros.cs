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
    
    public partial class carros
    {
        public carros()
        {
            this.contratocarro1 = new HashSet<contratocarro>();
            this.entradasaida = new HashSet<entradasaida>();
        }
    
        public int IDCARROS { get; set; }
        public int CONTRATOCARRO_IDCONTRATOCARRO { get; set; }
        public int MANUTENCAO_IDMANUTENCAO { get; set; }
        public int MODELOS_IDMODELO { get; set; }
        public int COR_IDCOR { get; set; }
        public string PLACA { get; set; }
        public string RENAVAM { get; set; }
        public string CHASSI { get; set; }
        public int ANO_FAB { get; set; }
        public int ANO_MOD { get; set; }
        public int QUILOMETRAGEM { get; set; }
        public decimal VALOR_DIARIA { get; set; }
        public System.DateTime DATA_AQUISICAO { get; set; }
        public Nullable<sbyte> ARCONDICIONADO { get; set; }
        public Nullable<sbyte> DIRECAOHIDRAULICA { get; set; }
        public Nullable<sbyte> VIDROELETRICO { get; set; }
        public Nullable<sbyte> AIRBAG { get; set; }
        public Nullable<sbyte> ABS { get; set; }
        public int LUGARES { get; set; }
        public int PORTAS { get; set; }
    
        public virtual modelos modelos { get; set; }
        public virtual cor cor { get; set; }
        public virtual manutencao manutencao { get; set; }
        public virtual contratocarro contratocarro { get; set; }
        public virtual ICollection<contratocarro> contratocarro1 { get; set; }
        public virtual ICollection<entradasaida> entradasaida { get; set; }
    }
}