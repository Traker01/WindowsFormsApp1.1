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
    
    public partial class Faktury_Zewnetrzne
    {
        public int ID { get; set; }
        public float Nr_Faktury { get; set; }
        public Nullable<int> ID_Grupa { get; set; }
        public string Nazwa_Firmy { get; set; }
        public float Cena_Netto { get; set; }
        public float Cena_Brutto { get; set; }
        public float Podatek { get; set; }
    
        public virtual Grupa Grupa { get; set; }
    }
}
