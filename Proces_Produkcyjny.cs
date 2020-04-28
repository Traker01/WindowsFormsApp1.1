//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Proces_Produkcyjny
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Proces_Produkcyjny()
        {
            this.Kontrola_Efektywnosci = new HashSet<Kontrola_Efektywnosci>();
            this.Material_Na_Produkcji = new HashSet<Material_Na_Produkcji>();
            this.Realizacja_Procesu = new HashSet<Realizacja_Procesu>();
            this.Zapotrzebowanie_Opakowan = new HashSet<Zapotrzebowanie_Opakowan>();
        }
    
        public int ID_Procesu_Produkcyjnego { get; set; }
        public int ID_Zamowienia { get; set; }
        public int ID_Proces_Technologiczny { get; set; }
        public Nullable<System.DateTime> Data_Rozpoczecia { get; set; }
        public Nullable<System.DateTime> Data_Zakonczenia { get; set; }
        public Nullable<int> ID_Dokumentacja_Proces { get; set; }
        public string Uwagi { get; set; }
    
        public virtual Dokumentacja_Proces Dokumentacja_Proces { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kontrola_Efektywnosci> Kontrola_Efektywnosci { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Material_Na_Produkcji> Material_Na_Produkcji { get; set; }
        public virtual Proces_Technologiczny Proces_Technologiczny { get; set; }
        public virtual Zamowienia Zamowienia { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Realizacja_Procesu> Realizacja_Procesu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Zapotrzebowanie_Opakowan> Zapotrzebowanie_Opakowan { get; set; }
    }
}
