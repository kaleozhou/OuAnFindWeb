//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MODEL
{
    using System;
    using System.Collections.Generic;
    
    /// <summary>
    /// FindRecharge
    /// </summary>
    public partial class FindRecharge
    {
        /// <summary>
        /// 
        /// </summary>
        public int FrId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Nullable<int> FuId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Nullable<decimal> FrAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Nullable<System.DateTime> FrRechargeDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FrRechargeStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FrIntroduce { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FrAuditor { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Nullable<System.DateTime> FrAuditorDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FrOperator { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Nullable<System.DateTime> FrOperateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FrStatus { get; set; }
    
        public virtual FindUsers FindUsers { get; set; }
    }
}
