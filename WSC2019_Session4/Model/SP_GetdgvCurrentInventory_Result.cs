//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WSC2019_Session4.Model
{
    using System;
    
    public partial class SP_GetdgvCurrentInventory_Result
    {
        public string PartName { get; set; }
        public string TransactionType { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<double> Amount { get; set; }
        public Nullable<int> SourceID { get; set; }
        public Nullable<int> DestinationID { get; set; }
        public Nullable<int> SupplierID { get; set; }
    }
}
