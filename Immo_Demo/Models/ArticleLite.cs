﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Immo_Demo.Models
    

{
    using System;
    using System.Collections.Generic;
    using IMMO.DAL;
    
    public partial class ArticleLite
    {
        public ArticleLite()
        {
            this.IMMO_AMORTISSEMENTANNUELLE = new HashSet<IMMO_AMORTISSEMENTANNUELLE>();
            this.IMMO_AMORTISSEMENTPARTIELLE = new HashSet<IMMO_AMORTISSEMENTPARTIELLE>();
            this.IMMO_ARTICLE_SESSION = new HashSet<IMMO_ARTICLE_SESSION>();
            this.IMMO_HIST_AFFECTATION_ARTICLE = new HashSet<IMMO_HIST_AFFECTATION_ARTICLE>();
            this.IMMO_INVETAIRE_ARTICLE = new HashSet<IMMO_INVETAIRE_ARTICLE>();
        }
    
        public string CODE { get; set; }
        public string FAMILLE { get; set; }
        public string CENTREACHAT { get; set; }
        public string AFFECTATION { get; set; }
        public Nullable<System.DateTime> DATEAFFECTATION { get; set; }
        public Nullable<System.DateTime> DATEAQUISITION { get; set; }
        public Nullable<decimal> ANNEEBL { get; set; }
        public Nullable<decimal> NUMBL { get; set; }
        public Nullable<decimal> NUMLIGBL { get; set; }
        public string NUMFACTURE { get; set; }
        public Nullable<System.DateTime> DATEEXPLOITATION { get; set; }
        public Nullable<decimal> DUREE { get; set; }
        public Nullable<decimal> TAUXAMORTISSEMENT { get; set; }
        public Nullable<decimal> DOTATIONANTERIEURE { get; set; }
        public Nullable<decimal> VALEURCOMPTABLE { get; set; }
        public Nullable<System.DateTime> DATESESSION { get; set; }
        public Nullable<decimal> VALEURSESSION { get; set; }
        public string RAISONSESSION { get; set; }
        public string AMORTI { get; set; }
        public string ETAT { get; set; }
        public string DESIGNATION { get; set; }
        public string ETATSESSION { get; set; }
        public string COMPTE { get; set; }
        public string REFERENCE { get; set; }
        public string CARACTERISTIQUE { get; set; }
        public Nullable<decimal> ANNEE { get; set; }
        public string SERVICE { get; set; }
        public string LOCALE { get; set; }
        public string Emplacement { get; set; }
    
        public virtual CODEBAR CODEBAR { get; set; }
        public virtual IMMO_AFFECTATION IMMO_AFFECTATION { get; set; }
        public virtual ICollection<IMMO_AMORTISSEMENTANNUELLE> IMMO_AMORTISSEMENTANNUELLE { get; set; }
        public virtual ICollection<IMMO_AMORTISSEMENTPARTIELLE> IMMO_AMORTISSEMENTPARTIELLE { get; set; }
        public virtual ICollection<IMMO_ARTICLE_SESSION> IMMO_ARTICLE_SESSION { get; set; }
        public virtual ICollection<IMMO_HIST_AFFECTATION_ARTICLE> IMMO_HIST_AFFECTATION_ARTICLE { get; set; }
        public virtual IMMO_COMPTE IMMO_COMPTE { get; set; }
        public virtual IMMO_DETAILBL IMMO_DETAILBL { get; set; }
        public virtual IMMO_DETAILFACTURE IMMO_DETAILFACTURE { get; set; }
        public virtual ICollection<IMMO_INVETAIRE_ARTICLE> IMMO_INVETAIRE_ARTICLE { get; set; }
        public virtual IMMO_FAMILLE IMMO_FAMILLE { get; set; }
        public virtual IMMO_SERVICE IMMO_SERVICE { get; set; }
        public virtual IMMO_LOCAL IMMO_LOCAL { get; set; }
        public virtual IMMO_EMPLACEMENT IMMO_EMPLACEMENT { get; set; }
        public virtual IMMO_EXERCICE IMMO_EXERCICE { get; set; }
    }
}
