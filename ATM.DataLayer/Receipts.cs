//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ATM.DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Receipts
    {
        public int TransactionID { get; set; }
        public int TransactionAmount { get; set; }
        public int OriginCardID { get; set; }
        public int DestinationCardID { get; set; }
        public System.DateTime TransactionDate { get; set; }
        public string Description { get; set; }
    
        public virtual CreditCards CreditCards { get; set; }
        public virtual CreditCards CreditCards1 { get; set; }
    }
}
