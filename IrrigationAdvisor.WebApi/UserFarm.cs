//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IrrigationAdvisor.WebApi
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserFarm
    {
        public long UserFarmId { get; set; }
        public long UserId { get; set; }
        public long FarmId { get; set; }
        public string Name { get; set; }
        public System.DateTime StartDate { get; set; }
    
        public virtual Farm Farm { get; set; }
        public virtual User User { get; set; }
    }
}