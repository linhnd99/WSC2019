//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WSC2019.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChangedPart
    {
        public string ID { get; set; }
        public Nullable<int> EmergencyMaintenanceID { get; set; }
        public string PartID { get; set; }
        public Nullable<double> Amount { get; set; }
    
        public virtual EmergencyMaintenance EmergencyMaintenance { get; set; }
        public virtual Part Part { get; set; }
    }
}
