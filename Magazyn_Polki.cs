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
    
    public partial class Magazyn_Polki
    {
        public string ID_Polka { get; set; }
        public string ID_Rozmiar_Polki { get; set; }
    
        public virtual Magazyn_Polki_Rozmiary Magazyn_Polki_Rozmiary { get; set; }
    }
}
