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
    
    public partial class IMMO_HIST_AFFECTATION
    {
        public IMMO_HIST_AFFECTATION()
        {
            this.IMMO_HIST_AFFECTATION_ARTICLE = new HashSet<IMMO_HIST_AFFECTATION_ARTICLE>();
        }
    
        public decimal ANNEE { get; set; }
        public decimal NUM { get; set; }
        public System.DateTime DATEAFFECTATION { get; set; }
        public string ANCIENNEAFFECTATION { get; set; }
        public string NOUVELLEAFFECTATION { get; set; }
        public string ETAT { get; set; }
        public string OBSERVATION { get; set; }
    
        public virtual ICollection<IMMO_HIST_AFFECTATION_ARTICLE> IMMO_HIST_AFFECTATION_ARTICLE { get; set; }
    }
}