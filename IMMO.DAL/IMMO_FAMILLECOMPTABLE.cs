//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IMMO.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class IMMO_FAMILLECOMPTABLE
    {
        public IMMO_FAMILLECOMPTABLE()
        {
            this.IMMO_COMPTE = new HashSet<IMMO_COMPTE>();
        }
    
        public string CODE { get; set; }
        public string LIBELLE { get; set; }
        public string CONTREPARTIE { get; set; }
        public Nullable<decimal> TAUX { get; set; }
        public string CONTREPARTIESECONDAIRE { get; set; }
        public string LIBELLEESECONDAIRE { get; set; }
    
        public virtual ICollection<IMMO_COMPTE> IMMO_COMPTE { get; set; }
    }
}
