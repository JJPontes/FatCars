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
    
    public partial class cliente
    {
        public cliente()
        {
            this.contratos = new HashSet<contratos>();
            this.telefonecliente = new HashSet<telefonecliente>();
        }
    
        public int IDCLIENTE { get; set; }
        public int USUARIO_IDUSUARIO { get; set; }
        public int ENDERECO_IDENDERECO { get; set; }
        public string NOME_CLIENTE { get; set; }
        public string TIPO_CLIENTE { get; set; }
        public Nullable<sbyte> STATUS_CLIENTE { get; set; }
        public string CPF { get; set; }
        public string CNPJ { get; set; }
        public string EMAIL { get; set; }
        public Nullable<System.DateTime> DT_NASCIMENTO { get; set; }
    
        public virtual usuarios usuarios { get; set; }
        public virtual endereco endereco { get; set; }
        public virtual ICollection<contratos> contratos { get; set; }
        public virtual ICollection<telefonecliente> telefonecliente { get; set; }
    }
}