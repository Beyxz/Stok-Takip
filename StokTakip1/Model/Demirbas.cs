//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StokTakip1.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Demirbas
    {
        public Demirbas()
        {
            this.Demirbas_Departman = new HashSet<Demirbas_Departman>();
        }
    
        public int DemirbasNo { get; set; }
        public Nullable<int> UrunId { get; set; }
        public string DemirbasKodu { get; set; }
        public string DemirbasAdi { get; set; }
        public Nullable<int> DemirbasAdedi { get; set; }
        public string DemirbasAciklama { get; set; }
    
        public virtual ICollection<Demirbas_Departman> Demirbas_Departman { get; set; }
        public virtual Urun Urun { get; set; }
    }
}
