//------------------------------------------------------------------------------
// <auto-generated>
//    O código foi gerado a partir de um modelo.
//
//    Alterações manuais neste arquivo podem provocar comportamento inesperado no aplicativo.
//    Alterações manuais neste arquivo serão substituídas se o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace projetoRestaurante.modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class cardapio
    {
        public cardapio()
        {
            this.item_cardapio = new HashSet<item_cardapio>();
        }
    
        public int idcardapio { get; set; }
        public string descricao { get; set; }
    
        public virtual ICollection<item_cardapio> item_cardapio { get; set; }
    }
}
