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
    
    public partial class IMMO_COMPTE
    {
        public IMMO_COMPTE()
        {
            this.IMMO_ARTICLE = new HashSet<IMMO_ARTICLE>();
            this.IMMO_FAMILLE = new HashSet<IMMO_FAMILLE>();
        }
    
        public string NUM { get; set; }
        public string INTITULE { get; set; }
        public Nullable<decimal> TAUX { get; set; }
        public Nullable<decimal> DUREE { get; set; }
        public string FAMILLECPT { get; set; }
        public string LINEAIRE { get; set; }
    
        public virtual ICollection<IMMO_ARTICLE> IMMO_ARTICLE { get; set; }
        public virtual ICollection<IMMO_FAMILLE> IMMO_FAMILLE { get; set; }
        public virtual IMMO_FAMILLECOMPTABLE IMMO_FAMILLECOMPTABLE { get; set; }
    }
}